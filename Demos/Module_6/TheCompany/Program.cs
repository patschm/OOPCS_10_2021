using System;
using System.Globalization;

namespace TheCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Bokito bok = new Bokito();
            Patrick pat = new Patrick();
            Peter p = new Peter();
            Robert r = new Robert();

            ACME acme = new ACME();

            acme.Hire(p);
            acme.Hire(pat);
            acme.Hire(r);
            acme.Hire(bok);

            // acme.StoomFluit();

            IContract c1 = bok;
            IContractTwo c2 = bok;

            c1.Voeruit();
            c2.Voeruit();

            Console.WriteLine(bok);
        }
    }
}
