using System;

namespace EvolutieTheorieDerDelegates
{

    delegate int MathDel(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(1, 2);

            // dotnet 1.0/.1.1 (2002, 2003)
            MathDel d1 = new MathDel(Add);
            result = d1(2, 3);

            // dotnet 2.0 (2005)
            MathDel d2 = Add;
            result = d2(3, 4);
         
            MathDel d3 = delegate(int a, int b)
            {
                return a + b;
            };
            result = d3(4, 5);

            // dotnet 3.0 (2008)
            MathDel d4 =  (a, b) => a + b;
            result = d4(5, 6);

            // Procedures
            Action<string> a = (s) => Console.WriteLine(s);
            a("Ha!");

            // Functions
            Func<int> b = () => 42;

            a(b().ToString());

            Func<int, int, int> d5 = (a, b) => a + b;
            result = d5(6, 7);

           

            // C# 8.0 (2018)
            result = SubAdd(7, 8);
            int SubAdd(int a, int b)
            {
                return a + b + result;
            }

            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
