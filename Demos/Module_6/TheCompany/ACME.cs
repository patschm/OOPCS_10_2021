using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    interface IContractTwo
    {
        void Voeruit();
    }
    interface IContract
    {
        void Voeruit();
    }

    class ACME
    {
        private IContract[] werknemers = new IContract[5];

        public void Hire(IContract werknemer)
        {
            for(int i = 0; i < werknemers.Length; i++)
            {
                if (werknemers[i] == null)
                {
                    werknemers[i] = werknemer;
                    return;
                }
            }
        }
        public void StoomFluit()
        {
            Console.WriteLine("Stoomfluit gaat af");
            foreach(IContract emp in werknemers)
            {
                emp?.Voeruit();
            }
        }
    }
}
