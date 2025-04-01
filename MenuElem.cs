using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éttermi_Rendelési_Rendszer
{
    class MenuElem
    {
        public string nev { get; set; }
        public int ar { get; set; }
        public string kategoria { get; set; }

        public MenuElem(string nev, int ar, string kategoria)
        {
            this.nev = nev;
            this.ar = ar;
            this.kategoria = kategoria;
        }
    }
}