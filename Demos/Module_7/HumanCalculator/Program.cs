using System;

namespace HumanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimonVdMeer sim = new SimonVdMeer();
            WillemKlein wil = new WillemKlein();

            string s = "hallo " + "world";
            //wil.Bereken(sim.Add, 4, 5);
            //wil.Bereken(sim.Subtract, 4, 5);

            Problem del = sim.Add;
            del += sim.Subtract;
            del += sim.Add;
            del -= sim.Add;

            foreach(var fn in del.GetInvocationList())
            {
                Console.WriteLine(fn.Method.Name);
            }

            int result = del(1, 2);
            Console.WriteLine(result);
        }
    }
}
