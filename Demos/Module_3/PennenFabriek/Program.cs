using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace PennenFabriek
{
    class Pen
    {
        // Fields. Hierin slaan we de eigenschappen van een object op.
        private int lineWidth = 1;
        //private ConsoleColor lineColor = ConsoleColor.Black;

        // Prpperties
        // Geven gecontroleerd toegang tot jouw private fields (Encapsulation)
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
        // Auto generating property.
        public ConsoleColor LineColor { get; set; } = ConsoleColor.Cyan;

        // Zo deden we dat in Java en C++. Niet hip.
        public void SetLineWidth(int lw)
        {
            if (lw > 0 && lw < 100)
            {
                lineWidth = lw;
            }
        }
        public int GetLineWidth()
        {
            return lineWidth;
        }

        // Methods. Hierin definieren wij het gedrag van het object
        public void Schrijf(string text)
        {
            Console.ForegroundColor = LineColor;
            Console.WriteLine($"{text} in lijndikte {LineWidth}");
            Console.ResetColor();
        }

        // Constructors. Hiermee geef je de fields een initiele waarde
        public Pen(ConsoleColor kleur, int lineWidth = 1)
        {
            LineWidth = lineWidth;
            LineColor = kleur;
        }
        public Pen() //: this(ConsoleColor.Black, 1)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IHost host = Host.CreateDefaultBuilder().ConfigureServices(list =>{
            //    list.AddTransient<Pen, Pen>();
            //}).Build();

            //Pen px = host.Services.GetRequiredService<Pen>();
            //px.lineColor = ConsoleColor.Gray;
            //px.Schrijf("Hoi");

            Pen obj = new Pen(ConsoleColor.Red, 3);
            //obj.SetLineWidth(20);
            //obj.LineWidth = 15;
            //obj.lineColor = ConsoleColor.Red;

            Pen p2 = new Pen { LineColor = ConsoleColor.Blue };
            //p2.lineColor = ConsoleColor.Green;
            //p2.lineWidth = 5;

            obj.Schrijf("Hallo");
            p2.Schrijf("World");
        }
    }
}
