/* Alunno: Francesco Di Lena.
 * Classe: 4F
 * Data: 06/10/2021
 * Consegna: Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
 * scrivere il codice di un programma (OOP) in C# che visualizzi i prezzi maggiori di 100€.
*/

using System;

namespace Cellulari
{
    class Cellulari //Classe in cui vengono eseguite le operazioni sui prezzi dei cellulari inseriti.
    {
        float[] PrezziCellulari;
        public Cellulari(float[] PrezziCellulari) //Metodo costruttore.
        {
            this.PrezziCellulari = PrezziCellulari;
        }
        public float[] RidimensionamentoVettore(ref int n) //Metodo che permette di ridimensionare il vettore PrezziCellulari.
        {
            if (PrezziCellulari[n] != -1)
            {
                Array.Resize(ref PrezziCellulari, PrezziCellulari.Length + 1); //Il vettore PrezziCellulari viene ridimensionato ogni volta che viene fatto l'inserimento di un prezzo diverso da -1.
                n++;
            }
            return PrezziCellulari;
        }
        public float[] SelezionaPrezzi() //Metodo che permette di individuare quali sono i prezzi maggiori di 100 euro.
        {
            for (int i = 0; i < PrezziCellulari.Length; i++)
            {
                if (PrezziCellulari[i] <= 100)
                {
                    PrezziCellulari[i] = -1;
                }
            }
            return PrezziCellulari;
        }
    }

    class Program //Classe a cui il programma fa riferimento al suo avvio.
    {
        static float[] PrezziCellulari = new float[1];
        static void Main(string[] args) //Nel Main sono contenute solamente le visualizzazioni a schermo e le richieste di input.
        {
            Console.WriteLine("Benvenuto nel programma.");
            int n = 0;
            Cellulari c = new Cellulari(PrezziCellulari);
            do
            {
                Console.WriteLine($"\nInserisci il {n + 1}o prezzo (in euro). Per terminare l'inserimento inserisci \"-1\":");
                PrezziCellulari[n] = float.Parse(Console.ReadLine());
                PrezziCellulari = c.RidimensionamentoVettore(ref n);

            }
            while (PrezziCellulari[n] != -1);
            Console.WriteLine($"\nI prezzi dei cellulari maggiori di 100 euro sono i seguenti:");
            for (int i = 0; i < PrezziCellulari.Length; i++)
            {
                c.SelezionaPrezzi();
                if (PrezziCellulari[i] != -1) 
                {
                    Console.WriteLine($"\n{i + 1}) {c.SelezionaPrezzi()[i]} euro.");
                }
            }
            Console.WriteLine("\nPer uscire dal programma premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }
}
