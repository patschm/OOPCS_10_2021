using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanCalculator
{
    delegate int Problem(int x, int y);

    class WillemKlein
    {
        public void Bereken(Problem p, int a, int b)
        {
            Console.WriteLine("Willem gaat nu rekenen...");
            int resultaat = p(a, b);


            Console.WriteLine($"Willem kraait: De uitkomst is {resultaat}");
        }

    }
}
