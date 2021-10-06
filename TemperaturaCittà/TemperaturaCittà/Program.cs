/* Alunno: Francesco Di Lena.
 * Classe: 4F
 * Data: 01/10/2021
 * Consegna: dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
   certa città, scrivere il codice di un programma (OOP) in C# che determini e visualizzi la temperatura
   più bassa e quella più alta.
*/


using System;

namespace TemperaturaCittà
{
    class Temperature
    {
        double[] TemperatureCittà { get; set; }
        public Temperature(double [] TemperatureCittà)
        {
            this.TemperatureCittà = TemperatureCittà;
        }
        public double [] OrdinaTemperature()
        {
            Array.Sort(TemperatureCittà);
            return TemperatureCittà;
        }
    }

    class Program
    {
        static double[] TemperatureCittà;
        static string nomeCittà;
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma. Inserisci il nome della città:");
            nomeCittà = Console.ReadLine();
            Console.WriteLine("\nInserisci il numero di temperature");
            int numeroTemperature = int.Parse(Console.ReadLine());
            TemperatureCittà = new double[numeroTemperature];
            for (int i = 0; i < numeroTemperature; i++)
            {
                Console.WriteLine($"\nInserisci la {i + 1}a temperatura:");
                TemperatureCittà[i] = double.Parse(Console.ReadLine());
            }
            Temperature t = new Temperature(TemperatureCittà);
            Console.WriteLine($"\nLe temperature di {nomeCittà} (gradi centigradi) sono, ordinate in modo crescente: ");
            for (int i = 0; i < TemperatureCittà.Length; i++)
            {
                Console.WriteLine($"\n{i + 1}) {t.OrdinaTemperature()[i]}.");
            }
            Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }
}
