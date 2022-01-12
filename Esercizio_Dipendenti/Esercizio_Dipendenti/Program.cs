/* Alunno: Francesco Di Lena
 * Classe: 4F
 * Consegna: Si crei la classe dipendente con i soli attributi: matricola, nome e cognome. La classe avrà un
             metodo che calcola la retribuzione oraria. Dalla nostra classe dipendente vogliamo derivare tre
             differenti classi: dirigente, impiegato e operaio. Visualizzare la retribuzione oraria dei tre dipendenti
             sapendo che la retribuzione oraria per l’operario è 35€/h mentre per l’impiegato la retribuzione
             aumenta del 30% e per il dirigente del 50%.
*/

using System;

namespace Esercizio_Dipendenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma!\n");
            Dirigente AmministratoreDelegato = new Dirigente("Ernesto", "Bianchi", "ERBI0001");
            Impiegato Contabile = new Impiegato("Roberto", "Giglio", "ROGI0001");
            Operaio AddettoMacchine = new Operaio("Francesco", "Rossi", "FRRO0001");
            Console.WriteLine($"La retribuzione oraria del dipendente {AmministratoreDelegato.ToString()} è di {AmministratoreDelegato.CalcolaRetribuzioneOraria()} euro/h.");
            Console.WriteLine($"La retribuzione oraria del dipendente {Contabile.ToString()} è di {Contabile.CalcolaRetribuzioneOraria()} euro/h.");
            Console.WriteLine($"La retribuzione oraria del dipendente {AddettoMacchine.ToString()} è di {AddettoMacchine.CalcolaRetribuzioneOraria()} euro/h.\n");
            Console.WriteLine("Per uscire dal programma, premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }

    class Dipendente
    {
        protected string nome, cognome, matricola;

        public Dipendente(string nome, string cognome, string matricola)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.matricola = matricola;
        }

        public virtual int CalcolaRetribuzioneOraria()
        {
            return 35;
        }

        new public virtual string ToString()
        {
            return $"{nome} {cognome} {matricola}";
        }
    }

    class Dirigente : Dipendente
    {
        public Dirigente(string nome, string cognome, string matricola) : base(nome, cognome, matricola)
        {

        }

        public override int CalcolaRetribuzioneOraria()
        {
            return base.CalcolaRetribuzioneOraria() + (base.CalcolaRetribuzioneOraria() / 100 * 50);
        }

        public override string ToString()
        {
            return base.ToString() + ", di mansione dirigente";
        }
    }

    class Impiegato : Dipendente
    {
        public Impiegato(string nome, string cognome, string matricola) : base(nome, cognome, matricola)
        {

        }

        public override int CalcolaRetribuzioneOraria()
        {
            return base.CalcolaRetribuzioneOraria() + (base.CalcolaRetribuzioneOraria() / 100 * 30);
        }

        public override string ToString()
        {
            return base.ToString() + ", di mansione impiegato";
        }
    }

    class Operaio : Dipendente
    {
        public Operaio(string nome, string cognome, string matricola) : base(nome, cognome, matricola)
        {
            
        }

        public override int CalcolaRetribuzioneOraria()
        {
            return base.CalcolaRetribuzioneOraria();
        }

        public override string ToString()
        {
            return base.ToString() + ", di mansione operaio";
        }
    }
}
