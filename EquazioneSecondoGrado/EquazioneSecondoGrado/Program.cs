/* Alunno: Francesco Di Lena
 * Classe: 4F
 * Data: 05/10/2021
 * Consegna: scrivere il codice di un programma (OOP) che calcoli la soluzione di un'equazione di secondo grado.
 */

using System;

namespace EquazioneSecondoGrado
{
    class Program
    {
        static bool verifica = false;
        static int a = 0, b = 0, c = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto. Questo programma calcola le soluzioni di un'equazione di secondo grado.");
            do
            {
                Console.WriteLine("Inserisci il primo coefficiente dell'equazione (a):");
                verifica = int.TryParse(Console.ReadLine(), out a);
            }
            while (verifica == false);
            do
            {
                Console.WriteLine("Inserisci il secondo coefficiente dell'equazione (b):");
                verifica = int.TryParse(Console.ReadLine(), out b);
            }
            while (verifica == false);
            do
            {
                Console.WriteLine("Inserisci il terzo coefficiente dell'equazione (c):");
                verifica = int.TryParse(Console.ReadLine(), out c);
            }
            while (verifica == false);
            EquazioneSecondoGrado e = new EquazioneSecondoGrado(a, b, c);
            Console.WriteLine(e.ToString() + "\n\nPer uscire dal programma premere un tasto qualsiasi...");
            Console.ReadKey();
        }
    }
    class EquazioneSecondoGrado
    {
        int a, b, c;
        string visualizzazione;
        public EquazioneSecondoGrado(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int VerificaEquazione()
        {
            int n;
            if (a == 0)
            {
                n = 0;
            }
            else
            {
                n = 1;
            }
            return n;
        }
        public double CalcolaDelta()
        {
            double delta = 0;
            if (VerificaEquazione() != 0)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
            }
            return delta;
        }
        public double[] SoluzioniEquazione()
        {
            double[] Soluzioni = new double[2];
            if(VerificaEquazione() != 0)
            {
                if (CalcolaDelta() < 0)
                {
                    Soluzioni[0] = Soluzioni[1] = Convert.ToDouble(null);
                }
                else if (CalcolaDelta() == 0)
                {
                    Soluzioni[0] = Soluzioni[1] = (-b) / (2 * a);
                }
                else
                {
                    Soluzioni[0] = (-b + Math.Sqrt(CalcolaDelta())) / (2 * a);
                    Soluzioni[1] = (-b - Math.Sqrt(CalcolaDelta())) / (2 * a);
                }
            }
            return Soluzioni;
        }
        public string ToString()
        {
            if(VerificaEquazione() != 0)
            {
                if (SoluzioniEquazione()[0] == SoluzioniEquazione()[1] && SoluzioniEquazione()[1] == Convert.ToDouble(null))
                {
                    visualizzazione = $"\nL'equazione non ha soluzioni.";
                }
                else if (SoluzioniEquazione()[0] == SoluzioniEquazione()[1])
                {
                    visualizzazione = $"\nL'unica soluzione dell'equazione è {SoluzioniEquazione()[0]}";
                }
                else
                {
                    visualizzazione = $"\nLa prima soluzione dell'equazione è {SoluzioniEquazione()[0]}, mentre la seconda è {SoluzioniEquazione()[1]}";
                }
            }
            else
            {
                visualizzazione = ("\nL'equazione inserita è di primo grado: la soluzione di equazioni di questo tipo non viene calcolate dal programma.");
            }
           
            return visualizzazione;
        }
    }

}
