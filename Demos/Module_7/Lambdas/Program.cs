using Bogus;
using System;
using System.Linq;

namespace Lambdas
{
    class Program
    {

        static void Main(string[] args)
        {
            string p = "hallo";
            p.Blaat();

            var people = new Faker<Person>()
                .RuleFor(p => p.ID, fk => fk.IndexGlobal)
                .RuleFor(p => p.FirstName, fk => fk.Name.FirstName())
                .RuleFor(p => p.LastName, fk => fk.Name.LastName())
                .RuleFor(p => p.Age, fk => fk.Random.Number(0, 123))
                .Generate(1000);

            // Linq
            string first = "E";
            var query = people.OrderBy(p =>p.LastName).OrderBy(p=>p.Age);
            //var query = people.Where(p =>p.FirstName.StartsWith(first));
            //var q = people.Where(FirstnameStartingWithB);


            foreach(Person p in query)
            {
                Console.WriteLine(p);
            }

        }

        static bool FirstnameStartingWithB(Person p)
        {
            return p.FirstName.StartsWith(f);
        }
        static bool FirstnameStartingWithA(Person p)
        {
            return p.FirstName.StartsWith("A");
        }

        static string SortByFirstName(Person p)
        {
            return p.FirstName;
        }
        static string SortByLastName(Person p)
        {
            return p.LastName;
        }
        static int SortByAge(Person p)
        {
            return p.Age;
        }
    }

    public static class MyExt
    {
        public static string Blaat(this string s)
        {
            return $"Bla bla {s}";
        }
    }
}
