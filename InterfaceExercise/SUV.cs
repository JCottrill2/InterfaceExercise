using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public SUV(double engineSize, string make, int numberOfWheels, string year, string slogan, string companyName, bool hasChangedGears)
        {
            EngineSize = engineSize;
            Make = make;
            NumberOfWheels = numberOfWheels;
            Year = year;
            Slogan = slogan;
            CompanyName = companyName;
            HasChangedGears = hasChangedGears;
        }

        public SUV(double v1, string v2, int v3)
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Kia";
        public int NumberOfWheels { get; set; } = 4;
        public string Year { get; set; } = "2015";
        public string Slogan { get; set; } = "Movement that inspires!";
        public string CompanyName { get; set; }
        public bool HasChangedGears { get; set; }
        object IVehicle.Slogan { get; set; } = "Movement that inspires";

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
