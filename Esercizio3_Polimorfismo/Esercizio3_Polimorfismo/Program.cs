/* Autore: Francesco Di Lena
 * Classe: 4F
 * Consegna: Si crei la classe Aerei con i seguenti attributi: codaereo, tipo, nome (inteso come nome
             aereolinea). La classe avrà 2 metodi che calcolano il costo del mezzo
             utilizzato e il costo per il suo utilizzo (calcolato dal percorso effettuato).
             Dalla classe si vogliono derivare 2 differenti classi: Cargo e Passeggeri.
             Visualizzare il costo dei 2 mezzi sapendo che il costo di un mezzo generico è
             5.000.000€ mentre per il Cargo è aumentato del 35% e per il Passeggeri aumenta
             del 45%. Per ciò che riguarda il consumo, dopo aver letto in input i km
             effettuati, si conosce che il prezzo al km per il Cargo è 500€ per il Passeggeri è 750€.
*/

using System;

namespace Esercizio3_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma!");
            Console.WriteLine("Inserisci il numero di kilometri percorsi dal primo aereo:");
            Passeggeri AereoPasseggeri = new Passeggeri("Alitalia", "Boeing 754", "0001", int.Parse(Console.ReadLine()));
            Console.WriteLine("Inserisci il numero di kilometri percorsi dal secondo aereo:");
            Cargo AereoCargo = new Cargo("TrasportiAerei", "Boeing 5009", "0002", int.Parse(Console.ReadLine()));
            Console.WriteLine($"\n1) {AereoPasseggeri.ToString()}, al costo generale di {AereoPasseggeri.CostoMezzo()} euro e un costo del percorso di {AereoPasseggeri.CostoPercorso()} euro.");
            Console.WriteLine($"2) {AereoCargo.ToString()}, al costo generale di {AereoCargo.CostoMezzo()} euro e un costo del percorso di {AereoCargo.CostoPercorso()} euro.\n");
            Console.WriteLine("Per uscire dal programma, premi un tasto qualsiasi...");
            Console.ReadKey();
        }
    }

    class Aerei
    {
        protected string nome, tipo, codiceAereo;
        private int costoGenerico;

        public Aerei(string nome, string tipo, string codiceAereo)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.codiceAereo = codiceAereo;
            this.costoGenerico = 5000000;
        }

        public virtual int CostoMezzo()
        {
            return costoGenerico;
        }

        public virtual int CostoPercorso()
        {
            return 0;
        }

        new public virtual string ToString()
        {
            return $"{nome} {tipo} {codiceAereo}";
        }
    }

    class Passeggeri : Aerei
    {
        private int percentualeAumento, prezzoKilometro, kilometriPercorsi;
        public Passeggeri(string nome, string tipo, string codiceAereo, int kilometriPercorsi) : base(nome, tipo, codiceAereo)
        {
            this.percentualeAumento = 35;
            this.prezzoKilometro = 500;
            this.kilometriPercorsi = kilometriPercorsi;
        }

        public override int CostoMezzo()
        {
            return base.CostoMezzo() + (base.CostoMezzo() / 100 * percentualeAumento);
        }

        public override int CostoPercorso()
        {
            return base.CostoPercorso() + (prezzoKilometro * kilometriPercorsi);
        }

        public override string ToString()
        {
            return base.ToString() + $", che ha percorso {kilometriPercorsi} km";
        }
    }

    class Cargo : Aerei
    {
        private int percentualeAumento, prezzoKilometro, kilometriPercorsi;

        public Cargo(string nome, string tipo, string codiceAereo, int kilometriPercorsi) : base(nome, tipo, codiceAereo)
        {
            this.percentualeAumento = 45;
            this.prezzoKilometro = 750;
            this.kilometriPercorsi = kilometriPercorsi;
        }

        public override int CostoMezzo()
        {
            return base.CostoMezzo() + (base.CostoMezzo() / 100 * percentualeAumento);
        }

        public override int CostoPercorso()
        {
            return base.CostoPercorso() + (prezzoKilometro * kilometriPercorsi);
        }

        public override string ToString()
        {
            return base.ToString() + $", che ha percorso {kilometriPercorsi} km";
        }
    }
}
