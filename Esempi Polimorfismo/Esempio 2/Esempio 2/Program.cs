/* Nome: Francesco Di Lena
 * Classe: 4F
 * Viene scritto il codice di un programma OOP che contenga le proprietà di incapsulamento, ereditarietà e polimorfismo: esempio 2, overloading.
 */

using System;

namespace Esempio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Somma2 ogg = new Somma2();
            Console.WriteLine(ogg.Somma(10, 20));
            Console.WriteLine(ogg.Somma(10.5f, 20.5f));
            Console.WriteLine(ogg.Somma("salve", " a tutti"));
            Console.ReadKey();
        }
    }

    class Somma1
    {
        public int Somma(int a, int b)
        {
            return a + b;
        }
        public float Somma(float x, float y)
        {
            return x + y;
        }
    }

    class Somma2 : Somma1
    {
        public string Somma(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
