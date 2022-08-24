using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Ford";
        public int NumberOfWheels { get; set; } = 4;
        public string Year { get; set; } = "2023";
        public string Slogan { get; set; } = "Built Ford Tough!";
        public string CompanyName { get; set; }
        public bool HasChangedGears { get; set; }

        public bool Has4WheelDrive { get; set; } = true;
        object IVehicle.Slogan { get; set; } = "Built Ford Tough";

        public void Drive()
        {
            if (Has4WheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive{GetType().Name} is now driving forward..");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward..");
            }

        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked, you may exit.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot put car in park without changing gears!");
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now driving in reverse..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse vehicle without changing gears!");
            }
            Console.WriteLine();
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
