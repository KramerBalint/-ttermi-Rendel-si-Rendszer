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
        public string nev;
        public int ar;
        public string kategoria;
        public MenuElem(string nev, int ar, string kategoria)
        {
            this.nev = nev;
            this.ar = ar;
            this.kategoria = kategoria;
        }

        public string GetNev()
        {
            return nev;
        }

        public int GetAr()
        {
            return ar;
        }
        public string GetKategoria()
        {
            return kategoria;
        }

        public void SetNev(string nev)
        {
            this.nev = nev;
        }
        public void SetAr(int ar)
        {
            this.ar = ar;
        }
        public void SetKategoria(string kategoria)
        {
            this.kategoria = kategoria;
        }
    }
}