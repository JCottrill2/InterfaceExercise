using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Chevrolet";
        public int NumberOfWheels { get; set; } = 4;
        public string Year { get; set; } = "2004";
        public string Slogan { get; set; } = "Like a Rock!";
        public string CompanyName { get; set; }
        public bool HasChangedGears { get; set; }
        object IVehicle.Slogan { get; set; } = "Like a Rock!";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving forward..");
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
