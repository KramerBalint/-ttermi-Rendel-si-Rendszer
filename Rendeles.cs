using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éttermi_Rendelési_Rendszer
{
    class Rendeles
    {
        public string nev;
        public List<MenuElem> rendeles = new List<MenuElem>();

        public Rendeles(string nev)
        {
            this.nev = nev;
        }
        public string GetNev()
        {
            return nev;
        }
        public void SetNev(string nev)
        {
            this.nev = nev;
        }
        public void RendelesKiirasa()
        {
            for (int i = 0; i < rendeles.Count; i++)
            {
                Console.WriteLine(rendeles[i].nev + " " + rendeles[i].ar);
            }
            int osszeg = 0;
            rendeles.ForEach(x => osszeg += x.ar);
            Console.WriteLine("A rendelés összege: " + osszeg);
        }
    }
}
