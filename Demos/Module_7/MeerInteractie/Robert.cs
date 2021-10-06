using System;

namespace MeerInteractie
{
    public interface IAktie
    {
        void Execute(int keer);
    }
    public delegate void Aktie(int dummy);

    public class Robert
    {
        public void Execute(Aktie fun)
        {
            Console.WriteLine("Robert voert het volgende uit:");
            fun(2);

        }
        public void Execute(IAktie fun)
        {
            Console.WriteLine("Robert voert het volgende uit:");
            fun.Execute(2);

        }
    }
}