using System;

namespace MeerInteractie
{
    class Program
    {
        static void Main(string[] args)
        {
            Robert rob = new Robert();
            Patrick pat = new Patrick();

            int x = 7;
            Aktie a1 = Ontplof;

            //a1(4);

            //pat.Bestelling();
            rob.Execute(pat);
            rob.Execute(pat.Bestelling);
        }

        static void Ontplof(int keer)
        {
            for(int i = 0; i < keer; i++)
            {
                Console.WriteLine("Kaboom!!!");
            }
        }
    }
}
