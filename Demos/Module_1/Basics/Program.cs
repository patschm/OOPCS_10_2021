using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 100000; i++)
            {
                s.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            // Type varname
            int age = 10;  // age is een variabele, 10 is een literal

            int res = age * 4;

            Console.WriteLine(res);

            int? x = null;

            // x?.Value

            StringBuilder b = null;

            doeIets(b);
            
                 

            int result = x ?? 42;

            //{
                string name = "Jan";
            //}//

            bool ok = age > 10 && age < 20;

           //byte age2  = age as byte;
           
            Console.WriteLine(age++);

            switch (age)
            {
                case 9:
                case 10:
                    Console.WriteLine("Tien");
                    break;
                default:
                    {
                        Console.WriteLine("Anders");
                        break;
                    }
            }
            int xs = 9;
            for (Console.WriteLine("Begin"); xs < 20 ; Console.WriteLine("Einde iteratie") )
            {
                if (++xs == 15) continue;
                Console.WriteLine(xs);
            }

            do
            {

            }
            while (xs < 30);

            while(xs< 30)
            {

            }

            List<int> nummers = new List<int>();
            int[] nummer = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int teller = 0; teller < nummer.Length; teller++)
            {
                int nr = nummer[teller];
                Console.WriteLine(nr);
            }
            foreach(int nr in nummer)
            {
                Console.WriteLine(nr);
            }
            //nummer[0] = 56;

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            matrix[0, 1] = 42;

            int[,,] kubus = new int[3, 4, 5];

            int[][] jagged = new int[3][];
            jagged[0] = new int[6];
            jagged[1] = new int[10];

            jagged[0][2] = 42;

        }

        private static void doeIets(StringBuilder b)
        {
            b?.ToString();
        }
    }
}
