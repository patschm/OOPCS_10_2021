using System;

namespace Overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generaliseren!!!
            Pen vp = new Vulpen { LineColor = ConsoleColor.Green };
            vp.Schrijf("Hallo");
            vp.Schrijf("Hallo");
            vp.Schrijf("Hallo");
            vp.Schrijf("Hallo");
            vp.Schrijf("Hallo");
            vp.Schrijf("Hallo"); 
            vp.Schrijf("Hallo");

            Pen bp = new Balpen { LineColor = ConsoleColor.Red };
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
            bp.Schrijf("Hallo");
        }
    }
}
