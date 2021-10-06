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
        string NomeCittà { get; set; }
        public Temperature(double [] TemperatureCittà)
        {
            this.TemperatureCittà = TemperatureCittà;
        }
        public void LetturaTemperature()
        {
            Console.WriteLine("Benvenuto nel programma. Inserisci il nome della città:");
            NomeCittà = Console.ReadLine();
            Console.WriteLine("\nInserisci il numero di temperature");
            int numeroTemperature = int.Parse(Console.ReadLine());
            TemperatureCittà = new double[numeroTemperature];
            for (int i = 0; i < numeroTemperature; i++)
            {
                Console.WriteLine($"Inserisci la {i + 1}a temperatura:");
                TemperatureCittà[i] = double.Parse(Console.ReadLine());
            }
        }
        public void OrdinaTemperature()
        {
            Array.Sort(TemperatureCittà);
        }
        public void MostraRisultati()
        {
            for (int j = 0, j < TemperatureCittà.Length; j++)
            {
                Console.WriteLine($"{j + 1}) {TemperatureCittà[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
