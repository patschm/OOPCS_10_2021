using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Robert: Employee
    {
        public override void Werkt()
        {
            DoetIets();
        }
        public void DoetIets()
        {
            Console.WriteLine("Robert doet iets");
        }
    }
}
