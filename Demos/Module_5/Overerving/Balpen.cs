using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    sealed class Balpen : Pen
    {
        // override activeert het polymorfisme
        public sealed override void Schrijf(string text)
        {        
            Console.ForegroundColor = LineColor;
            Console.WriteLine($"Balpen: {text} in lijndikte {LineWidth}");
            Console.ResetColor();
        }
    }

    //class MultiBalpen : Balpen
    //{
    //    public override void Schrijf(string text)
    //    {
    //        Console.ForegroundColor = LineColor;
    //        Console.WriteLine($"Balpen: {text} in lijndikte {LineWidth}");
    //        Console.ResetColor();
    //    }
    //}
}
