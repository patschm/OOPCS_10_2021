using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    delegate void OntvangstMethode(string message);

    class RadioStation
    {
        //private OntvangstMethode _ontvangers;

        public event OntvangstMethode ontvangers;
        //{
        //    add
        //    {
        //        _ontvangers += value;
        //    }
        //    remove
        //    {
        //        _ontvangers -= value;
        //    }
        //}

        public void Broadcast()
        {
            ontvangers?.Invoke("Hallo luisteraars");
        }
    }
}
