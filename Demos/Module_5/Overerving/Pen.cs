using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    abstract class Pen
    {
        private int lineWidth = 1;
        public int LineWidth
        {
            get
            {
                return lineWidth;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    lineWidth = value;
                }
            }
        }
        public ConsoleColor LineColor { get; set; } = ConsoleColor.Cyan;

        // Virtual maak Schrijf Polymorf-ready
        // Abstract verplicht tot overriden
        public abstract void Schrijf(string text);
        //{
        //    Console.ForegroundColor = LineColor;
        //    Console.WriteLine($"{text} in lijndikte {LineWidth}");
        //    Console.ResetColor();
        //}
    }
}
