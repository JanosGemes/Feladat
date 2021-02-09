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

        public bool Aktive()
        {
            return this.aktivalva;
        
        }

        public string MelyikSzoba()
        {
            return this.hely;
        }

        public string TargyNeve()
        {
            return this.nev;
        }

        public string Felvetel()
        {
            hely = "taska";
            return hely;
        
        }

        

    }
        class Program
    {
        static void Main(string[] args)
        {
            Targy[] targy = new Targy[]
                {
                new Targy (0, "szekrény", "szoba", false)
                new Targy (1, "ajtó", "szoba", false)
                new Targy (2, "ablak", "szoba", false)
                new Targy (3, "doboz", "szoba", false)
                new Targy (4, "kulcs", "szoba", false)
                new Targy (5, "feszítővas", "fürdőszoba", false)
                new Targy (6, "kád", "fürdőszoba", false)
                new Targy (7, "ágy", "szoba", false)

                };
        }
    }
}
