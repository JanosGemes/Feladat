using System;
using System.Collections.Generic;
using System.Text;

namespace SzabadulasASzobabol
{
    class Targy
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

        public bool Aktive()            // megvizsgálja a tárgy aktiváltságát(használtuk-e már)
        {
            return this.aktivalva;
        }

        public string TargyHelye()     // megadja a tárgy helyét
        {
            return this.hely;
        }

        public string TargyNeve()       // megadja a tárgy nevét
        {
            return this.nev;
        }

        public string Felvetel()        // a tárgy helyét módosítja, a táskába kerül
        {
            hely = "taska";
            return hely;
        }

        public string LetetelSzoba()    // a tárgy helyét módosítja, bekerül a szobába
        {
            hely = "szoba";
            return hely;
        }

        public string LetetelFurdoszoba()   // a tárgy helyét módosítja, bekerül a fürdőszobába
        {
            hely = "fürdőszoba";
            return hely;
        }

        public bool Aktivalva()     // a tárgyat aktiválja(használathoz), értékét true-ra módosítja
        {
            aktivalva = true;
            return aktivalva;
        }

        public string Elhuzva()     // tárgy helyét módosítja(szekrény)
        {
            hely = "elhúzva";
            return hely;
        }

        public void NezdTargy()     //egy tárgyról ad leírást
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
                    Console.WriteLine("Be van zárva, kézzel nem lehet betörni, valamivel be kéne törnöd");
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

        public string HelyValt      //betöltéshez, a tárgy helyét tölti vissza
        {
            set
            {
                hely = value;
            }
        }
        public bool AtivalasValt    //betöltéshez, a tárgy aktiválását tölti vissza
        {
            set
            {
                aktivalva = value;

            }
        }
    }
}
