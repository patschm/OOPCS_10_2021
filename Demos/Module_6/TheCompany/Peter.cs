using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Peter : Employee
    {
        public override void Werkt()
        {
            Proggt();
        }
        public void Proggt()
        {
            Console.WriteLine("Peter programmeert");
        }
    }
}
