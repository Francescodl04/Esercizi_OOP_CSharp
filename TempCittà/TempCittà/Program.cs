/* Autore: Francesco Di Lena
 * Classe: 4 F
 * Data: 01/10/2021
 * Consegna: Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
   certa città, scrivere il codice di un programma (OOP) in C# che determini e visualizzi la temperatura
   più bassa e quella più alta. (ESERCIZIO 5)
 */

using System;

namespace TemperatureCittà
{
    class TemperatureCittà //Classe che permette di svolgere le operazioni con le temperature.
    {
        int min;
        int max;
        public TemperatureCittà() //Metodo costruttore.
        {
            min = -9999;
            max = 9999;
        }
        public int Minimo(int t) //Metodo che stabilisce la temperatura minore fra quelle inserite.
        {
            if (min < t)
            {
                min = t;
            }
            return min;
        }
        public int Massimo(int t) //Metodo che stabilisce la temperatura maggiore fra quelle inserite.
        {
            if (max > t)
            {
                max = t;
            }
            return max;
        }
    }
    class Program //Classe a cui il programma fa riferimento al suo avvio.
    {
        static void Main(string[] args) //Nel Main vengono inserite le visualizzazioni video e le richieste di input.
        {
            Console.WriteLine("Quante temperature vuoi inserire?");
            int n, min = 0, max = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n < 2) 
                {
                    Console.WriteLine("\nNon puoi inserire un numero minore di 2, pertanto reinserisci il numero:");
                }
            }
            while (n < 2);
            TemperatureCittà k = new TemperatureCittà();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci la {i + 1}a temperatura:");
                int t = int.Parse(Console.ReadLine());
                min = k.Minimo(t);
                max = k.Massimo(t);
            }
            Console.WriteLine("\nLa temperatura massima è: " + max);
            Console.WriteLine("\nLa temperatura minima è: " + min);
            Console.WriteLine("\nPer uscire dal programma premi un tasto qualsiasi...");
            Console.ReadKey();

        }
    }
    
}
