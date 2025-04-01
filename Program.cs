namespace Éttermi_Rendelési_Rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etterem etterem = new Etterem();
            etterem.Menu = new FajlKezelo().MenuBetoltese();

            Vendeg vendeg1 = new Vendeg("Kiss Péter");

            MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
            MenuElem cola = new MenuElem("Kóla", 500, "Ital");

            etterem.HozzaadMenu(burger);
            etterem.HozzaadMenu(cola);

            etterem.ListazMenut();

            vendeg1.Rendel(burger);
            vendeg1.Rendel(cola);

            etterem.UjRendeles(vendeg1);

            new FajlKezelo().MenuMentese(etterem.Menu);
            new FajlKezelo().RendelesMentese(etterem.Rendelesek);

            vendeg1.RendelesTorlese();
        }
    }
}
