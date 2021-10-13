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
    class Temperature //Classe che permette di svolgere le operazioni con le temperature in seguito a quando sono state dichiarate nel Main.
    {
        public double[] TemperatureCittà;
        public double min;
        public double max;
        public Temperature(double[] TemperatureCittà) //Metodo costruttore.
        {
            this.TemperatureCittà = new double[1];
        }
        public double[] RidimensionamentoVettore() //Metodo che permette di ridimensionare la matrice TemperatureCittà.
        {
            Array.Resize(ref TemperatureCittà, TemperatureCittà.Length + 1); //Il vettore TemperatureCittà viene ridimensionato ogni volta in cui si inserisce una nuova temperatura.
            return TemperatureCittà;
        }
        public double[] OrdinaTemperature() //Metodo che ordina le temperature e ne determina la minima e la massima.
        {
            Array.Sort(TemperatureCittà); //Il metodo Array.Sort ordina in modo crescente il vettore TemperatureCittà.
            min = TemperatureCittà[0];
            max = TemperatureCittà[TemperatureCittà.Length - 2];
            return TemperatureCittà;
        }
    }

    class Program //Classe eseguita direttamente dal programma al suo avvio.
    {
        static void Main(string[] args) //Nel Main vengono lasciate solamente le visualizzazioni video e le richieste input.
        {
            double[] TemperatureCittà = new double[0];
            string nomeCittà;
            Temperature t = new Temperature(TemperatureCittà);
            Console.WriteLine("Benvenuto nel programma. Inserisci il nome della città:");
            nomeCittà = Console.ReadLine();
            int n = 0;
            while (t.TemperatureCittà[n] != 999 )
            {
                Console.WriteLine($"\nInserisci la {n + 1}a temperatura: (se vuoi fermarti inserisci i caratteri \"999\")");
                t.TemperatureCittà[n] = int.Parse(Console.ReadLine());
                if (t.TemperatureCittà[n] != 999)
                {
                    n++;
                    t.RidimensionamentoVettore();
                }
            }
            Console.WriteLine($"\nLe temperature di {nomeCittà} (gradi centigradi) sono, ordinate in modo crescente: ");
            for (int i = 1; i < t.TemperatureCittà.Length; i++)
            {
                Console.WriteLine($"\n{i}) {t.OrdinaTemperature()[i - 1]}.");
            }
            Console.WriteLine($"\nLa temperatura minima è {t.min}, mentre quella massima è {t.max}");
            Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }
}
