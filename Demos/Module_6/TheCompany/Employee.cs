using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Employee : Person, IContract
    {
        public void Voeruit()
        {
            Werkt();
        }

        public virtual void Werkt()
        {
            Console.WriteLine("Werkt");
        }
    }
}
