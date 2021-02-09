using System;

namespace SzabadulasASzobabol
{
    public class Targy
    {
        int sorszam;
        string nev, hely;
        bool aktivalva;

        public Targy(int sorszam, string nev, string hely, bool aktivalva)
        {
            this.sorszam = sorszam;
            this.nev = nev;
            this.hely = hely;
            this.aktivalva = aktivalva;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!");
        }
    }
}
