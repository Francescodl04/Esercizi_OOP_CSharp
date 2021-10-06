/* Alunno: Francesco Di Lena
 * Classe: 4F
 * Consegna: tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input 3
   età, di 3 persone diverse, calcoli e visualizzi in output la loro media.
 */

using System;

namespace Persone
{
    class Persone
    {
        int[] EtàPersone;
        double media;

        public Persone()
        {
            EtàPersone = new int[3] { 0, 0, 0 };
        }

        public void LeggiInput()
        {
            Console.WriteLine("Benvenuto nel programma!");
            for (int i = 0; i < EtàPersone.Length; i++)
            {
                Console.WriteLine($"Inserisci l'età della {i + 1}a persona:");
                EtàPersone[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double CalcolaMedia()
        {
            media = (EtàPersone[0] + EtàPersone[1] + EtàPersone[2]) / 3;
            return media;
        }

        public void VisualizzaMedia()
        {
            Console.WriteLine($"\nLa media delle età è: {CalcolaMedia()}");
        }

        public void EsciProgramma()
        {
            Console.WriteLine("Premi un tasto qualsiasi per uscire dal programma...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Persone p = new Persone();
            p.LeggiInput();
            p.CalcolaMedia();
            p.VisualizzaMedia();
            p.EsciProgramma();
        }
    }
}
