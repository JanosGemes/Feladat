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

        public string LetetelSzoba()
        {
            hely = "szoba";
            return hely;     
        }

        public string LetetelFurdoszoba()
        {
            hely = "fürdőszoba";
            return hely;
        }

        public bool Aktivalva()
        {
            aktivalva = true;
            return aktivalva;
        }

        public string Elhuzva()
        {
            hely = "elhúzva";
            return hely;

        }

        public void NezdTargy()
        {
            switch (nev)
            {
                case "szekrény":
                    Console.WriteLine("A nappaliban található szekrény kézzel nyitható ");
                    break;
                case "ágy":
                    Console.WriteLine("Ez egy közönséges ágy.");
                    break;
                case "ajtó":
                    Console.WriteLine("Keletre van egy ajtó, kulccsal nyitható");
                    break;
                case "kád":
                    Console.WriteLine("A kádban egy feszítővasat látsz.");
                    break;
                case "ablak":
                    Console.WriteLine("Be van zárva, kézzel nem lehet betörni");
                    break;
                case "kulcs":
                    Console.WriteLine("Ez egy kulcs, valószínű zárat nyit");
                    break;
                case "doboz":
                    Console.WriteLine("Kis nyitható doboznak tűnik");
                    break;
                case "feszítővas":
                    Console.WriteLine("szerszám, ezzel talán ki tudsz jutni");
                    break;
                default:
                    break;
            }
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
