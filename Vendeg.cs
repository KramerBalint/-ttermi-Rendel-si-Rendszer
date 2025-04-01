using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éttermi_Rendelési_Rendszer
{
    class Vendeg
    {
        public string nev;
        public List<MenuElem> rendeles = new List<MenuElem>();

        public Vendeg(string nev)
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

        public override string ToString()
        {
            return nev;
        }

        public void Rendel(MenuElem menuElem)
        {
            rendeles.Add(menuElem);
        }

        public void RendelesTorlese()
        {
            int osszeg = 0;
            rendeles.ForEach(x => osszeg += x.GetAr());
            Console.WriteLine("A rendelés összege: " + osszeg);
            rendeles.Clear();
        }
    }
}
