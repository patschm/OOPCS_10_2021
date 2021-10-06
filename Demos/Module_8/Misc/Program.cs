using System;
using System.Collections;
using System.Collections.Generic;

namespace Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo();
            //GenericsDemo();

            Collections();
        }

        private static void Collections()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(int x in list)
            {
                Console.WriteLine(x);
            }
        }

        private static void GenericsDemo()
        {
            Point pa = new Point { X = 10, Y = 20 };
            Point pb = new Point { X = 100, Y = 200 };
            int a = 10;
            int b = 20;
            Console.WriteLine($"a={a}, b={b}");
            Swap(ref pa, ref pb);
            Console.WriteLine($"a={a}, b={b}");
            Console.WriteLine(pa);
            Console.WriteLine(pb);
        }

        private static void Swap<T>(ref T aa, ref T bb) where T: new()
        {
            T c = aa;
            aa = bb;
            bb = c;
        }
        //private static void Swap(ref float aa, ref float bb)
        //{
        //    float c = aa;
        //    aa = bb;
        //    bb = c;
        //}
        //private static void Swap(ref long aa, ref long bb)
        //{
        //    long c = aa;
        //    aa = bb;
        //    bb = c;
        //}
        //private static void Swap(ref int aa, ref int bb)
        //{
        //    int c = aa;
        //    aa = bb;
        //    bb = c;
        //}

        private static void StructDemo()
        {
            Point p1 = new Point { X = 10, Y = 20 };

            Console.WriteLine(p1);
            DoeIets(p1);
            Console.WriteLine(p1);
        }

        private static void DoeIets(Point blaat)
        {
           blaat.X = 1000;
           blaat.Y = 2000;
        }
    }
}
