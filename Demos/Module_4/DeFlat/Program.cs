using System;

namespace DeFlat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oerknal
           // Etage.elevator.Call(122);


            Etage[] flat = new Etage[30];
            for(int i = 0; i < flat.Length; i++)
            {
                flat[i] = new Etage { EtageNummer = i };
            }

           // Etage.elevator

            flat[19].CallElevator();

            foreach(Etage et in flat)
            {
                et.ShowElevatorStatus();
            }
        }
    }

    class Etage
    {
        public int EtageNummer = 0;
        public static Lift elevator = new Lift();

        public void ShowElevatorStatus()
        {
            elevator.ShowStatus();
        }

        public void CallElevator()
        {
            // Static members worden ook wel class members genoemd 
            // omdat je de class naam voor zo'n member specificeert.
            // Members die op een object leven (this) worden instance members genoemd.
            Etage.elevator.Call(EtageNummer);
        }

    }

    class Lift
    {
        private int currentFloor = 0;

        public void ShowStatus()
        {
            Console.WriteLine($"De lift is op de {currentFloor}e verdieping");
        }
        public void Call(int etage)
        {
            Console.WriteLine($"Kom eraan {currentFloor}e verdieping");
            currentFloor = etage;
        }
    }
}
