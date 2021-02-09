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

    public class Helyseg
    {
        bool jelenlet;
        string szobaNeve;

        public Helyseg(string szobaNeve, bool jelenlet)
        {
            this.szobaNeve = szobaNeve;
            this.jelenlet = jelenlet;
        }

        public bool SzobaValtas()
        {

            if (jelenlet == true)
            {
                jelenlet = false;
                return jelenlet;
            }
            else
            {
                jelenlet = true;
                return jelenlet;
            }

        }

        public bool IttVagyokE()
        {
            return jelenlet;
        }

        public void SzobaNézd()
        {
            switch (szobaNeve)
            {
                case "szoba":
                    Console.WriteLine("A szobában vagy, keletre egy ajtó, északra egy szekrény, nyugatra egy ágy");
                    break;

                case "fürdőszoba":
                    Console.WriteLine("A fürdőben vagy, itt található egy kád");
                    break;

                default:
                    break;
            }
        }
    }

    class Program
    {
        static void Koszones()
        {
            Console.WriteLine("Üdvözöllek! \nEz a játék a Szabadulás a szobából! \nA nappaliban állsz és ki kell jutnod! \nA help szót beírva kiírja milyen parancsokat hajthatsz végre! \nJó szórakozást! ");
        }

        static void Help()
        {
            Console.WriteLine("A végrehajtandó cselekedetek: \nmenj (\"menj\" utasítás után égtájat tudsz beírni (észak, kelet, nyugat, dél) pl.: \"menj észak\" )" +
                                "\nnézd (A nézd utasítás tárggyal használva a tárgyról ad rövid leírást. pl.:\"nézd ágy\"" +
                                "\nA sima nézd utasítással szobát vizsgálod meg pl.:\"nézd\") " +
                                "\nvedd fel(A \"vedd fel\" utasítás után tárgyakat írhatsz be és bekerül a táskádba pl.: \"vedd fel kulcs\") " +
                                "\ntedd le (A \"tedd le\" utasítás után tárgyakat írhatsz be és kikerül a táskádból a szobába pl.: \"tedd le kulcs\")" +
                                "\nnyisd (A \"nyisd\" utasítás után megfelelő tárgyakat használva kinyilnak pl.:\"nyisd ajtó\", " +
                                "\n ha magától nem nyitható akkor be kell írni mivel szeretnéd nyitni pl.:\"nyisd ablak kulcs\")" +
                                "\nhúzd (A \"húzd\" utasítás után megfelelő tárgyat beírva elhúzhatók pl.:\"húzd ágy\")" +
                                "\ntörd (A \"törd\" utasítás után megfelelő tárgyat beírva, fel tudod törni azt pl.:\"törd szekrény\")" +
                                "\nleltar (A \"leltar\" utasítás után kilistázza a táskádban lévő dolgokat pl.:\"leltar\")");

        }

        static void Main(string[] args)
        {
            #region helységek, tárgyak

            Helyseg[] helyseg = new Helyseg[]
            {
                new Helyseg("szoba",true),
                new Helyseg("fürdőszoba",false),
            };


            Targy[] targy = new Targy[]
            {
                new Targy (0, "szekrény", "szoba", false),
                new Targy (1, "ajtó", "szoba", false),
                new Targy (2, "ablak", "szoba", false),
                new Targy (3, "doboz", "szoba", false),
                new Targy (4, "kulcs", "szoba", false),
                new Targy (5, "feszítővas", "fürdőszoba", false),
                new Targy (6, "kád", "fürdőszoba", false),
                new Targy (7, "ágy", "szoba", false),
            };

            #endregion

            Koszones();


            Console.ReadLine();
        }
    }
}
