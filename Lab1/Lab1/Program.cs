using Lab1.Figury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Pozycja
    {
        private string p;

        public Pozycja(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("05");
            Pozycja p2 = new Pozycja("04");
            Figura f = new Pionek(p);
            Console.WriteLine(f.CzyMoznaPrzesunac)

        }
    }
}
