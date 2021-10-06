/* Alunno: Francesco Di Lena
 * Classe: 4F
 * Data: 01/10/2021
 * Consegna: tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input 
 * il raggio di una circonferenza, calcoli e visualizzi in output la misura del diametro (2*r), della
 * circonferenza (2*r*pi) e la sua area (r^2 *pi). (Utilizzare la funzione Math.PI)
 */

using System;

namespace Circonferenza
{
    class Cerchio
    {
        int raggio { get; set; }
        int diametro { get; set; }
        double circonferenza { get; set; }
        double area { get; set; }

        public Cerchio(int raggio, int diametro, double circonferenza, double area)
        {
            this.raggio = raggio;
            this.diametro = diametro;
            this.circonferenza = circonferenza;
            this.area = area;
        }

        public void LeggiRaggio()
        {
            Console.WriteLine("Benvenuto nel programma. Inserisci la misura del raggio:");
            do
            {
                raggio = int.Parse(Console.ReadLine());
            }
            while (raggio <= 0);
        }

        public int CalcolaDiametro()
        {
            diametro = raggio * 2;
            Console.WriteLine($"\nIl diametro è {diametro}.");
            return diametro;
        }

        public double CalcolaCirconferenza()
        {
            circonferenza = 2 * raggio * Math.PI;
            Console.WriteLine($"\nLa misura della circonferenza è {circonferenza}.");
            return circonferenza;
        }

        public double CalcolaArea()
        {
            area = Math.Pow(2, raggio) * Math.PI;
            Console.WriteLine($"\nLa misura dell'area è {area}.");
            return area;
        }

        public void EsciProgramma()
        {
            Console.WriteLine("\nPremere un tasto qualsiasi per uscire dal programma...");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio(0,0,0,0);
            c.LeggiRaggio();
            c.CalcolaDiametro();
            c.CalcolaCirconferenza();
            c.CalcolaArea();
            c.EsciProgramma();
        }
    }
}
