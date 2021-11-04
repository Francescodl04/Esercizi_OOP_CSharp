/* Autore: Francesco Di Lena 
 * Classe: 4F
 * Data: 03/11/2021
 * Consegna: 
 * Creare una classe Squadra che rappresenta una squadra di calcio e ha come attributi il numero di partite vinte, il numero di partite perse, il numero di partite pareggiate e i gol fatti e subiti.
   Ha opportuni metodi per impostare i parametri e farli visualizzare, inoltre ha:

    ● il metodo Punti() che restituisce quanti punti ha in campionato (ogni partita vinta vale 3 punti, ogni partita pareggiata 1, quelle perse 0)
    ● un metodo InizioAnno() che resetta il numero di partite vinte, pareggiate e perse portandole a zero.
    ● il metodo GoalFatto()
    ● il motodo GoalSubito()

    eventualmente, con x = valore intero positivo
    ● il metodo goalFatto( int x)
    ● il motodo goalSubito(int x)

    Creare un main per provare la classe creando due istanze (ad es: Juventus e Milan) e si provino ad utilizzare facendo inserire all’utente per entrambe le squadre, 
    il numero di partite vinte, perse e pareggiate e quanti gol fatti e subiti e poi confrontando quale delle due ha più punti in campionato e quale delle due ha subito più goal 
    e quale ne ha fatti di più.
*/

using System; //Direttiva using che permette l'utilizzo di metodi generali.

namespace compito_3_11_2021
{
    class Program //Classe che viene richiamata dal programma ad ogni suo avvio.
    {
        static void Main(string[] args) //Il Main è il metodo a cui il programma fa riferimento per primo. Contiene le visualizzazioni a schermo e le acquisizioni input. 
        {
            bool verifica = true; //Variabile necessaria per rappresentare delle condizioni nei cicli do-while.
            string[,] DatiSquadre = new string[2, 6]; //Nome, gol fatti, gol subiti, numero partite vinte, numero partite pareggiate, numero partite perse
            string[] TestoDaVisualizzare = new string[] { "nome", "numero di gol fatti nell'ultima partita", "numero di gol subiti nell'ultima partita", "numero di partite vinte", "numero di partite pareggiate", "numero di partite perse" }; //Matrice che contiene parte del testo che dovrà essere visualizzato a schermo quando il rpogramma richiederà l'inserimento delle caratteristiche delle squadre.
            int indicePartenzaRichieste = 0; //Indice che è utilizzato per consentire la richiesta del nome di una squadra, a seconda del fatto che sia o meno il primo inserimento.
            Console.WriteLine("                                  Benvenuto nel programma                                  "); //Attraverso una visualizzazione a schermo, si introduce l'utente al programma.
            do //Qui comincia un ciclo do-while, che esegue almeno una volta le istruzioni contenute, per poi ripeterle nel caso in cui la condizione finale sia soddisfatta.
            {
                int[] punteggioSquadre = new int[2] { 0, 0 }; //Matrice che contiene i punteggi in classifica delle due squadre.
                int codiceSquadraGoalFattiMaggiore = 0, codiceSquadraGoalSubitiMaggiore = 0, codiceSquadraPunteggioMaggiore = 0; //Questi "codici" non rappresentano altro che indici necessari per individuare la posizione in cui si trovano i dati all'interno della matrice contenente i dati delle squadre (verrà inizializzata in seguito).
                for (int i = 0; i < 2; i++) //Con questo ciclo e il successivo vengono eseguite le istruzioni sottostanti fino a quando non è stato completato l'inserimento delle caratteristiche di ogni squadra per tutte e due le squadre.
                {
                    for (int j = indicePartenzaRichieste; j < 6; j++) 
                    {
                        Console.WriteLine($"\nInserisci il {TestoDaVisualizzare[j]} della {i + 1}a squadra"); //Invita l'utente a inserire le caratteristiche delle squadre.
                        DatiSquadre[i, j] = Console.ReadLine(); //Esegue l'assegnazione della stringa in input.
                        if (j > 0) //Solo il primo parametro sarà usato come stringa, mentre gli altri dovranno essere usati come interi, quindi viene effettuato un controllo sull'input.
                        {
                            verifica = int.TryParse(DatiSquadre[i, j], out int verificaInteger); //Il metodo int.TryParse "prova" a vedere se la stringa che si trova nel primo argomento è trasformabile in integer: se è possibile restituisce true, altrimenti restituisce false.
                            if (verifica == false || verificaInteger < 0) //Se non è stato inserito un numero intero oppure se il numero è minore di zero, vengono eseguite le istruzioni.
                            {
                                Console.WriteLine("\nDevi inserire un numero maggiore o uguale a zero. Ripeti l'inserimento..."); //Invita l'utente a ripetere l'inserimento.
                                j--; //j viene decrementato perché così avviene un ciclo in più in cui l'utente può inserire un numero consentito dal programma dove non lo aveva messo.
                            }
                        }
                    }
                    Squadra SquadraInserita = new Squadra(DatiSquadre[i, 0], int.Parse(DatiSquadre[i, 1]), int.Parse(DatiSquadre[i, 2]), int.Parse(DatiSquadre[i, 3]), int.Parse(DatiSquadre[i, 4]), int.Parse(DatiSquadre[i, 5])); //Viene istanziata la classe Squadra e vengono passate le caratteristiche inserite dall'utente per la squadra.
                    SquadraInserita.Punti(ref punteggioSquadre[i]); //Richiama il metodo Punti, facente parte della classe istanziata SquadraInserita.
                    Console.WriteLine(SquadraInserita.ToString()); //Richiama il metodo ToString della classe istanziata SquadraInserita.
                    if (i != 1) //Se deve essere ancora effettuato l'inserimento delle caratteristiche della seconda squadra, allora attende la conferma dell'utente per passare a questo inserimento.
                    {
                        Console.WriteLine("\nPer passare alla seconda squadra premi un tasto qualsiasi..."); //Invita l'utente a premere un tasto qualsiasi per passare all'inserimento delle caratteristiche della seconda squadra.
                    }
                    else //Quando è terminato l'inserimento della 
                    {
                        codiceSquadraGoalFattiMaggiore = SquadraInserita.GoalFatto(int.Parse(DatiSquadre[0,1]), int.Parse(DatiSquadre[1, 1]));
                        codiceSquadraGoalSubitiMaggiore = SquadraInserita.GoalSubito(int.Parse(DatiSquadre[0, 2]), int.Parse(DatiSquadre[1, 2]));
                        Console.WriteLine("\nPer proseguire premi un tasto qualsiasi..."); //Invita l'utente a premere un tasto qualsiasi per passare alle informazioni successive.
                    }
                    Console.ReadKey(); //Permette l'inserimento di un qualunque carattere da tastiera.
                    Console.Clear(); //Pulisce il contenuto della console.
                }
                Console.WriteLine("\n                                  CONSIDERAZIONI FINALI                                  "); //Intestazione introduttiva.
                //Avviene la visualizzazione a schermo, come previsto dalla consegna, di risultati finali, per quanto riguarda la squadra con i goal fatti/subiti maggiore e quella con la posizione più alta fra le due nella classifica del campionato.
                Console.WriteLine($"\nLa squadra che ha fatto più goal è {DatiSquadre[codiceSquadraGoalFattiMaggiore,0]} ({DatiSquadre[codiceSquadraGoalFattiMaggiore, 1]} goal segnati) e a subirne di più è stata {DatiSquadre[codiceSquadraGoalSubitiMaggiore, 0]}\n({DatiSquadre[codiceSquadraGoalSubitiMaggiore, 2]} goal subiti). La squadra, poi, che è più in alto nel campionato è {DatiSquadre[codiceSquadraPunteggioMaggiore, 0]} con {punteggioSquadre[codiceSquadraPunteggioMaggiore]} punti");
                //Avvisa l'utente che può scegliere se proseguire o meno con un nuovo inserimento delle caratteristiche.
                Console.WriteLine("\nSe vuoi proseguire inserendo dei nuovi dati per le due squadre (cancellando ovviamente\nquelli già presenti) inserisci \"S\", altrimenti inserisci \"N\" se vuoi uscire dal programma:");
                string scelta; //Identifica la scelta effettuata dall'utente.
                do //Qui comincia un ciclo do-while, che esegue almeno una volta le istruzioni contenute, per poi ripeterle nel caso in cui la condizione finale sia soddisfatta.
                {
                    scelta = Console.ReadLine().ToUpper(); //Legge l'input e lo assegna a scelta, rendendolo però tutto maiuscolo con il metodo ToUpper.
                    if (scelta != "S" && scelta != "N") //Viene controllato che sia stato inserito un valore accettabile dal programma.
                    {
                        Console.WriteLine("\nPuoi inserire solo \"S\" o \"N\", quindi ripeti l'inserimento..."); //Avvisa l'utente che ha sbagliato.
                        verifica = false; //Pone verifica uguale a false per eseguire di nuovo il ciclo.
                    }
                    else
                    {
                        verifica = true; //Pone verifica uguale a true solo se l'inserimento è corretto.
                    }
                }
                while (verifica == false); //Il ciclo si ripete fino a quando verifica non assume il valore true.
                switch (scelta) //In base al valore di scelta possono essere svolti due casi.
                {
                    case ("S"): //Caso 1: scelta=="S".
                        indicePartenzaRichieste = 1; //Il valore dell'indice viene posto uguale a uno, in modo che nel prossimo inserimento dei dati non venga richiesto il nome delle squadre.
                        Squadra Squadra = new Squadra("", 0, 0, 0, 0, 0); //Viene istanziata la classe Squadra.
                        Squadra.InizioAnno(ref DatiSquadre); //Effettua il reset di tutti le caratteristiche delle squadre, tranne i nomi, con il metodo InizioAnno della classe istanziata Squadra.
                        Console.Clear(); //Pulisce il contenuto della console.
                        verifica = false;
                        break;
                    case ("N"): //Caso 2: scelta=="N".
                        verifica = true;
                        break;
                }
            }
            while (verifica == false); //Il ciclo si ripete fino a quando verifica non assume il valore true.
            Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi..."); //Invita l'utente a premere un stato qualsiasi per uscire dal programma.
            Console.ReadKey(); //Attende che un carattere venga inserito da tastiera.
        }
    }

    class Squadra //La classe Squadra contiene tutti i metodi che riguardano la creazione e l'aggiornamento di una squadra oppure delle liste di squadre.
    {
        //Ognuno dei seguenti attributi è privato come da consegna.
        private string nomeSquadra { get; set; } //Attributo della classe che indica il nome della squadra.
        private int numeroPartiteVinte { get; set; } //Attributo della classe che indica il nome della squadra.
        private int numeroPartitePerse { get; set; } //Attributo della classe che indica il numero di partite perse dalla squadra.
        private int numeroPartitePareggiate { get; set; } //Attributo della classe che indica il numero di partite pareggiate dalla squadra.
        private int goalFatti { get; set; } //Attributo della classe che indica i goal fatti dalla squadra.
        private int goalSubiti { get; set; } //Attributo della classe che indica il goal subiti dalla squadra.


        //Ognuno dei seguenti metodi è pubblico come da consegna.

        public Squadra(string nomeSquadra, int goalFatti, int goalSubiti, int numeroPartiteVinte, int numeroPartitePareggiate, int numeroPartitePerse) //Metodo costruttore della classe che permette di assegnare i valori che vengono passati all'istanza agli attributi privati della classe corrente.
        {
            this.nomeSquadra = nomeSquadra;
            this.goalFatti = goalFatti;
            this.goalSubiti = goalSubiti;
            this.numeroPartiteVinte = numeroPartiteVinte;
            this.numeroPartitePareggiate = numeroPartitePareggiate;
            this.numeroPartitePerse = numeroPartitePerse;
        }

        public void Punti(ref int puntiOttenuti) //Metodo che non restituisce nulla, accetta un argomento in riferimento e permette di effettuare l'assegnazione dei punteggi ottenuti in classifica dalle squadre.
        {
            if (numeroPartiteVinte > 0) //Se ci sono delle partite vinte, allora assegna 3 punti per ogni partita vinta.
            {
                puntiOttenuti = numeroPartiteVinte * 3;
            }
            if (numeroPartitePareggiate > 0) //Se ci sono delle partite pareggiate, allora assegna un punto per ogni partita vinta.
            {
                puntiOttenuti = numeroPartiteVinte;
            }
        }

        public void InizioAnno(ref string [,] DatiGiocatori) //Metodo che non restituisce nulla, accetta un argomento in riferimento e permette di effettuare il reset delle informazioni delle squadre, tranne i loro nomi.
        {
            for (int i = 0; i < 2; i++) //Questi due cicli for permettono di riportare a 0 i valori numerici presenti nella matrice DatiGiocatori, quindi non il nome delle squadre.
            {
                for (int j = 1; j < 6; j++)
                {
                    DatiGiocatori[i, j] = "0";
                }
            }
        }

        public int GoalFatto(int goalFatti1, int goalFatti2) //Metodo che restituisce un valore interi, accetta due argomento e permette di individuare la squadra con il numero maggiore di goal fatti.
        {
            int codiceSquadra = 0; //Variabile necessaria per tenere conto dell'indice scelto dalla selezione sottostante.
            if (goalFatti1 > goalFatti2)
            {
                codiceSquadra = 0;
            }
            else if (goalFatti1 < goalFatti2)
            {
                codiceSquadra = 1;
            }
            return codiceSquadra;
        }

        public int GoalSubito(int goalSubiti1, int goalSubiti2) //Metodo che restituisce un valore intero, accetta due argomenti e permette di individuare la squadra con il numero maggiore di goal subiti.
        {
            int codiceSquadra = 0; //Variabile necessaria per tenere conto dell'indice scelto dalla selezione sottostante.
            if (goalSubiti1 > goalSubiti2) 
            {
                codiceSquadra = 0;
            }
            else if (goalSubiti1 < goalSubiti2)
            {
                codiceSquadra = 1;
            }
            return codiceSquadra;
        }

        public override string ToString() //Metodo che sovrasrive il metodo ToString, restituendo una stringa concatenata.
        {
            return $"\nLa squadra {nomeSquadra}, ha vinto {numeroPartiteVinte} partite, ha pareggiato {numeroPartitePareggiate} partite e ha perso {numeroPartitePerse} partite. \nHa poi, nell'ultima partita, fatto {goalFatti} goal e subito {goalSubiti} goal.";
        }
    }
}
