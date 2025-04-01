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
                Console.WriteLine(rendeles[i].GetNev() + " " + rendeles[i].GetAr());
            }
            int osszeg = 0;
            rendeles.ForEach(x => osszeg += x.GetAr());
            Console.WriteLine("A rendelés összege: " + osszeg);
        }
    }
}
