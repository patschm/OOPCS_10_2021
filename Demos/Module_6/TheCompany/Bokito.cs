using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Bokito : IContract, IContractTwo
    {
        //public void Voeruit()
        //{
        //    Console.WriteLine("van contract????");
        //    Werkt();
        //}

        void IContract.Voeruit()
        {
            Console.WriteLine("Van contract 1");
            Werkt();
        }
        void IContractTwo.Voeruit()
        {
            Console.WriteLine("Van contract 2");
            Werkt();
        }

        public void Werkt()
        {
            Console.WriteLine("Bokito ramt dames in elkaar");
        }
        public override string ToString()
        {
            return "Hi ik ben Bokito";
        }
    }
}
