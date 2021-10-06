/* Alunno: Francesco Di Lena.
 * Classe: 4F
 * Data: 06/10/2021
 * Consegna: Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
 * scrivere il codice di un programma (OOP) in C# che visualizzi i prezzi maggiori di 100€.
*/


using System;

namespace Cellulari
{
    class Cellulari
    {
        double[] PrezziCellulari { get; set; }
        public Cellulari(double[] PrezziCellulari)
        {
            this.PrezziCellulari = PrezziCellulari;
        }
        public double[] SelezionaPrezzi()
        {
            for (int i = 0; i < PrezziCellulari.Length; i++)
            {
                if (PrezziCellulari[i] <= 100)
                {
                    PrezziCellulari[i] = Convert.ToDouble(null);
                }
            }
            return PrezziCellulari;
        }
    }

    class Program
    {
        static double[] PrezziCellulari;
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma. Inserisci il numero di cellulari:");
            int numeroCellulari = int.Parse(Console.ReadLine());
            PrezziCellulari = new double[numeroCellulari];
            for (int i = 0; i < numeroCellulari; i++)
            {
                Console.WriteLine($"\nInserisci il {i + 1}o prezzo:");
                PrezziCellulari[i] = double.Parse(Console.ReadLine());
            }
            Cellulari t = new Cellulari(PrezziCellulari);
            Console.WriteLine($"\nI prezzi dei cellulari maggiori di 100 euro sono i seguenti:");
            for (int i = 0; i < PrezziCellulari.Length; i++)
            {
                if (PrezziCellulari[i] != Convert.ToDouble(null))
                {
                    Console.WriteLine($"\n{i + 1}) {t.SelezionaPrezzi()[i]}.");
                }
            }
            Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }
}
