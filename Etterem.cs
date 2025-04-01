using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éttermi_Rendelési_Rendszer
{
    class Etterem
    {
        public Etterem() { }

        public List<MenuElem> Menu = new List<MenuElem>();
        public List<Rendeles> Rendelesek = new List<Rendeles>();

        public void HozzaadMenu(MenuElem elem)
        {
            Menu.Add(elem);
        }

        public void UjRendeles(Vendeg vendeg)
        {
            Rendeles ujRendeles = new Rendeles(vendeg.GetNev());
            foreach (var menuElem in vendeg.rendeles)
            {
                ujRendeles.rendeles.Add(menuElem);
            }
            Rendelesek.Add(ujRendeles);
        }

        public void ListazMenut()
        {
            foreach (var elem in Menu)
            {
                Console.WriteLine($"{elem.GetNev()} - {elem.GetAr()} Ft - {elem.GetKategoria()}");
            }
        }

        public void RendelesekKiirasa()
        {
            foreach (var rendeles in Rendelesek)
            {
                Console.WriteLine($"Rendelés: {rendeles.GetNev()}");
                rendeles.RendelesKiirasa();
            }
        }
    }
}
