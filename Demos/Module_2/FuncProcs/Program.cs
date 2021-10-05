using System;

namespace FuncProcs
{
    class Program
    {
        static void Main(string[] args)
        {
            42.ToString();
            Console.WriteLine("Hello World!");

            //int getal;
            bool ok = int.TryParse("20a", out int getal);

            int getal2 = 100;
            DoeIets(out getal2);
            Console.WriteLine(getal2);

            int nr = TelOp(4, c:6);

            nr = TelOp(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );

            ShowNumber(nr);
        }

        static void DoeIets(out int nr)
        {          
            nr = 0;
            nr += 1000;
        }

        static void ShowNumber(int nummer)
        {
            Console.WriteLine($"Het nummer is {nummer}");
        }
        static int TelOp(int a, int b)
        {
            int res = a + b;
            return res;
        }
        static int TelOp(int a, int b = 0, int c = 0)
        {
            int res = a + b + c;
            return res;
        }
        static int TelOp(params int[] nummers)
        {
            int res = 0;
            foreach(int nr in nummers)
            {
                res += nr;
            }
            return res;
        }

    }
}
