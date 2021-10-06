using System;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new Patrick();
            RadioStation r538 = new RadioStation();

            r538.ontvangers += ViaEther;
            r538.ontvangers += ViaKabel;
            r538.ontvangers += ViaSMS;
            r538.ontvangers += ViaPostduif;
            r538.ontvangers += ViaEther;
            r538.ontvangers += ViaKabel;
            r538.ontvangers += ViaSMS;
            r538.ontvangers += ViaPostduif;
            r538.ontvangers += ViaEther;
            r538.ontvangers += ViaKabel;
            r538.ontvangers += ViaSMS;
            r538.ontvangers += p.ViaRookSignalen;
            r538.ontvangers += ViaPostduif;
            r538.ontvangers += ViaEther;
            r538.ontvangers += ViaKabel;
            r538.ontvangers += ViaSMS;
            r538.ontvangers += ViaPostduif;

            r538.Broadcast();

            //r538.ontvangers("Hey klojo's!!");
        }


        static void ViaEther(string msg)
        {
            Console.WriteLine($"Via Ether {msg}");
        }
        static void ViaKabel(string msg)
        {
            Console.WriteLine($"Via Kabel {msg}");
        }
        static void ViaSMS(string msg)
        {
            Console.WriteLine($"Via SMS {msg}");
        }
        static void ViaPostduif(string msg)
        {
            Console.WriteLine($"Via Postduif {msg}");
        }
    }
}
