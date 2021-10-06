using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    class Vulpen : Pen
    {
        private int inktLevel = 5;
       
        public override  void Schrijf(string text)
        {
            if (inktLevel <= 0)
            {
                Console.WriteLine("De vulpen is leeg");
                return;
            }
            Console.ForegroundColor = LineColor;
            Console.WriteLine($"Vulpen: {text} in lijndikte {LineWidth}");
            Console.ResetColor();
            inktLevel--;
        }
    }
}
