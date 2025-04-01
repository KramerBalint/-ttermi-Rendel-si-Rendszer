using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éttermi_Rendelési_Rendszer
{
    class FajlKezelo
    {
        public FajlKezelo()
        {
            if (!File.Exists("rendelesek.txt"))
            {
                File.Create("rendelesek.txt").Close();
            }
            if (!File.Exists("menu.txt"))
            {
                File.Create("menu.txt").Close();
            }
        }

        public void MenuMentese(List<MenuElem> menu)
        {
            using (StreamWriter sw = new StreamWriter("menu.txt"))
            {
                foreach (var elem in menu)
                {
                    sw.WriteLine($"{elem.nev};{elem.ar};{elem.kategoria}");
                }
            }
        }

        public List<MenuElem> MenuBetoltese()
        {
            List<MenuElem> menu = new List<MenuElem>();
            using (StreamReader sr = new StreamReader("menu.txt"))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string nev = parts[0];
                        int ar = int.Parse(parts[1]);
                        string kategoria = parts[2];
                        menu.Add(new MenuElem(nev, ar, kategoria));
                    }
                }
            }
            return menu;
        }

        public void RendelesMentese(List<Rendeles> rendelesek)
        {
            using (StreamWriter sw = new StreamWriter("rendelesek.txt"))
            {
                foreach (var rendeles in rendelesek)
                {
                    sw.WriteLine(rendeles.ToString());
                }
            }
        }
    }
}
