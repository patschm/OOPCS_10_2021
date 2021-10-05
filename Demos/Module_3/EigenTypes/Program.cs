using System;
using EigenTypes;

namespace EigenTypes
{
    enum WeekDay : ulong
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek dy;
            int weekDay = 4;

            WeekDay dag = (WeekDay)weekDay; //WeekDay.Monday;
            Console.WriteLine(dag);


        }
    }
}
