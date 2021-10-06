/* Alunno: Francesco Di Lena
 * Classe: 4F
 * Consegna: Tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver costruito
 * la classe Calciatore visualizzi in output: il nome del calciatore, il ruolo, la squadra e i gol segnati
 * (i dati vengono assegnati all'interno del codice)
 */

using System; /*Istruzione per l'utilizzo della libreria System che permette l'uso di usare alcune classi Console 
               * e i metodi Write e ReadLine*/

namespace Calciatore //Parola chiave per dichiarare un ambito che contiene un set di oggetti correlati
{
    class Calciatore //Definizione della classe pagina 20
    {
        //Attributi
        string nome;
        string squadra;
        string ruolo;
        int golSegnati;

        //Metodo di default: costruttore 

        public Calciatore(string nome, string squadra, string ruolo)
        {
            this.nome = nome; //La parola chiave "this" seve per inizializzare i campi membro (attributi)
            this.squadra = squadra;
            this.ruolo = ruolo;
            golSegnati = 0;
        }

        //Metodi

        public void aggiornaGolSegnati(int gol)
        {
            golSegnati += gol;
        }

        public void visualizzaGol()
        {
            Console.WriteLine($"\n{nome} - {ruolo} - {squadra} - Gol segnati: {golSegnati}");
        }

        public void leggiInput()
        {
            Console.WriteLine("Benvenuto nel programma. Inserisci il nome e cognome del calciatore:");
            nome = Console.ReadLine();
            Console.WriteLine("\nInserisci ruolo:");
            ruolo = Console.ReadLine();
            Console.WriteLine("\nInserisci squadra:");
            squadra = Console.ReadLine();
            Console.WriteLine("\nInserisci gol segnati:");
            golSegnati = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Calciatore c = new Calciatore("", "", "");
            c.leggiInput();
            c.visualizzaGol();
            c.aggiornaGolSegnati(+2);
            c.visualizzaGol();
            Console.ReadKey();
        }
    }

}