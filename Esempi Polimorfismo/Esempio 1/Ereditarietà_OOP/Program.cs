/* Nome: Francesco Di Lena
 * Classe: 4F
 * Viene scritto il codice di un programma OOP che contenga le proprietà di incapsulamento, ereditarietà e polimorfismo: esempio 1.
 */


using System;

namespace Ereditarietà_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma!\n");
            Utilitaria MiaAutomobile = new Utilitaria("Fiat", "500", 7500, "GPL", "Base");
            Berlina TuaAutomobile = new Berlina("BMW", "M5", 75000, "Diesel", "Luxury");
            Console.WriteLine($"La mia automobile è {MiaAutomobile.ToString()} e ha un costo di {MiaAutomobile.Costo()} euro\n");
            Console.WriteLine($"La tua automobile è {TuaAutomobile.ToString()} e ha un costo di {TuaAutomobile.Costo()} euro\n");
            Console.WriteLine("Per uscire dal programma, premi un tasto qualsiasi...");
            Console.ReadKey();
        }
    }

    public class Automobile
    {
        protected string marca, modello;
        protected int valore;

        public Automobile(string marca, string modello, int valore)
        {
            this.marca = marca;
            this.modello = modello;
            this.valore = valore;
        }

        public virtual int Costo()
        {
            return valore;
        }

        new public virtual string ToString()
        {
            return $"{marca} {modello}";
        }
    }

    public class Utilitaria : Automobile
    {
        private string alimentazione, dotazioni;

        public Utilitaria(string marca, string modello, int valore, string alimentazione, string dotazioni) : base(marca, modello, valore)
        {
            this.alimentazione = alimentazione;
            this.dotazioni = dotazioni;
        }

        public override int Costo()
        {
            return base.Costo() + 300;
        }

        public override string ToString()
        {
            return base.ToString() + $" {alimentazione} {dotazioni}";
        }

    }

    public class Berlina : Automobile
    {
        private string alimentazione, dotazioni;

        public Berlina(string marca, string modello, int valore, string alimentazione, string dotazioni) : base(marca, modello, valore)
        {
            this.alimentazione = alimentazione;
            this.dotazioni = dotazioni;
        }

        public override int Costo()
        {
            return base.Costo() + 5500;
        }

        public override string ToString()
        {
            return base.ToString() + $" {alimentazione} {dotazioni}";
        }
    }
}
