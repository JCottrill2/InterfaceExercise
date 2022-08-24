using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public double EngineSize { get; set; } 
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public string Year { get; set; }
        public bool HasChangedGears { get; set; }
        object Slogan { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
        
    }
}
