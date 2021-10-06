using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Patrick: Employee
    {
        public override void Werkt()
        {
            Raaskalt();
        }
        public void Raaskalt()
        {
            Console.WriteLine("Patrick kletst maar wat");
        }
    }
}
