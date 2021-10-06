using System;

namespace MeerInteractie
{
    public class Patrick : IAktie
    {
      public void Bestelling(int maal)
        {
            for (int i = 0; i < maal; i++)
            {
                Console.WriteLine("1 Ginger ale");
                Console.WriteLine("1 Cola");
                Console.WriteLine("1 Bier"); 
            }
        }

        public void Execute(int keer)
        {
            Bestelling(keer);
        }
    }
}