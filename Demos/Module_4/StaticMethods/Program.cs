using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex { Real = 10, Imaginary = 20 };
            c1.Display();
            Complex c2 = new Complex { Real = 20, Imaginary = 40 };
            c2.Display();

            //Complex dummy = new Complex();
            Complex c3 = c1 + c2;// Complex.Add(c1, c2);
            c3.Display();

        }
    }

    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public static Complex operator+(Complex a1, Complex a2)
        {
            return new Complex { 
                Real = a1.Real + a2.Real, 
                Imaginary = a1.Imaginary + a2.Imaginary 
            };
        }

        public void Display()
        {
            Console.WriteLine($"({Real} + {Imaginary}i)");
        }
             
    }
}
