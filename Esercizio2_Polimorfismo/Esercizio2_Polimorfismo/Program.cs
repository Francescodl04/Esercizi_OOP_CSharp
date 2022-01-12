/* Autore: Francesco Di Lena
 * Classe: 4F
 * Consegna: Si crei la classe Veicoli con i seguenti attributi: codveicolo, tipo, nome e marca. La classe avrà 2
             metodi che calcolano il costo del mezzo utilizzato e il costo per il suo
             utilizzo (calcolato dal percorso effettuato). Dalla classe si vogliono derivare
             2 differenti classi: Auto e Furgone. Visualizzare il costo dei 2 mezzi sapendo
             che il costo di un mezzo generico è 5.000€ mentre per l’auto è aumentato del
             25% e per il furgone aumenta del 40%. Per ciò che riguarda il consumo, dopo
             aver letto in input i km effettuati, si conosce che il prezzo al km per l’auto
             è 5€ per il furgone è 10€.
*/

using System;

namespace Esercizio2_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma!");
            Console.WriteLine("Inserisci il numero di kilometri percorsi con l'auto:");
            Auto AutoNoleggio = new Auto("Fiat", "Panda", "Utilitaria", 0001, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Inserisci il numero di kilometri percorsi con il furgone:");
            Furgone FurgoneNoleggio = new Furgone("Fiat", "Scudo", "Furgone commerciale", 0002, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"\n1) {AutoNoleggio.ToString()}, con un costo generale di {AutoNoleggio.CostoMezzo()} euro e un costo per il carburante di {AutoNoleggio.CostoPercorso()} euro.");
            Console.WriteLine($"1) {FurgoneNoleggio.ToString()}, con un costo generale di {FurgoneNoleggio.CostoMezzo()} euro e un costo per il carburante di {FurgoneNoleggio.CostoPercorso()} euro.\n");
            Console.WriteLine("Per uscire dal programma, premi un tasto qualsiasi...");
            Console.ReadKey();
        }
    }

    class Veicoli
    {
        protected string marca, nome, tipo;
        protected int codiceVeicolo;
        private int prezzoGenerico;

        public Veicoli(string marca, string nome, string tipo, int codiceVeicolo)
        {
            this.marca = marca;
            this.nome = nome;
            this.tipo = tipo;
            this.codiceVeicolo = codiceVeicolo;
            this.prezzoGenerico = 5000;
        }

        public virtual int CostoMezzo()
        {
            return prezzoGenerico;
        }

        public virtual int CostoPercorso()
        {
            return 0;
        }

        new public virtual string ToString()
        {
            return $"{marca} {nome} {tipo} {codiceVeicolo}";
        }
    }

    class Auto : Veicoli
    {
        private int aumentoPercentuale, prezzoKilometro, numeroKilometri;

        public Auto(string marca, string nome, string tipo, int codiceVeicolo, int numeroKilometri) : base(marca, nome, tipo, codiceVeicolo)
        {
            this.aumentoPercentuale = 25;
            this.prezzoKilometro = 5;
            this.numeroKilometri = numeroKilometri;
        }

        public override int CostoMezzo()
        {
            return base.CostoMezzo() + (base.CostoMezzo() / 100 * aumentoPercentuale);
        }

        public override int CostoPercorso()
        {
            return prezzoKilometro * numeroKilometri;
        }

        public override string ToString()
        {
            return base.ToString() + $" che ha percorso {numeroKilometri} km";
        }
    }

    class Furgone : Veicoli
    {
        private int aumentoPercentuale, prezzoKilometro, numeroKilometri;

        public Furgone(string marca, string nome, string tipo, int codiceVeicolo, int numeroKilometri) : base(marca, nome, tipo, codiceVeicolo)
        {
            this.aumentoPercentuale = 40;
            this.prezzoKilometro = 10;
            this.numeroKilometri = numeroKilometri;
        }

        public override int CostoMezzo()
        {
            return base.CostoMezzo() + (base.CostoMezzo() / 100 * aumentoPercentuale);
        }

        public override int CostoPercorso()
        {
            return prezzoKilometro * numeroKilometri;
        }

        public override string ToString()
        {
            return base.ToString() + $" che ha percorso {numeroKilometri} km";
        }
    }
}
