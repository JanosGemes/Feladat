using System;
using System.Collections.Generic;
using System.Text;

namespace SzabadulasASzobabol
{

    class Helyseg
    {
        bool jelenlet;
        string szobaNeve;

        public Helyseg()
        {
        }

        public Helyseg(string szobaNeve, bool jelenlet)
        {
            this.szobaNeve = szobaNeve;
            this.jelenlet = jelenlet;
        }

        public string SzobaNeve()       // a szoba nevét adja vissza
        {
            return this.szobaNeve;
        }

        public bool SzobaAktivitas()    // megvizsgálja a helységet, true vagy false add vissza
        {
            return this.jelenlet;
        }

        public bool SzobaValtas()       // szobák közti mozgáshoz szükséges, szobaváltás során megváltoztatja a true vagy false értéket
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

        public bool IttVagyokE()        //visszaadja, a szoba jelentét rétékét, ha true a szobában tartózkodik a karakter
        {
            return jelenlet;
        }

        public virtual void SzobaNézd()         // kijavítandó
        {

        }

        public bool JelenletValt        // betöltéshez, szobák true és false értékét tölti vissza
        {
            set
            {
                jelenlet = value;
            }
        }
    }
    class Szoba : Helyseg               // javított helység vizsgálat
    {
        public override void SzobaNézd()
        {
            Console.WriteLine("A szobában vagy, keletre egy ajtó, északra egy szekrény, nyugatra egy ágy");
        }
    }
    class Furdoszoba : Helyseg
    {
        public override void SzobaNézd()
        {
            Console.WriteLine("A fürdőben vagy, itt található egy kád");
        }
    }


}
