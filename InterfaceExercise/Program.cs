﻿using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE--Create 2 Interfaces called IVehicle & ICompany

            //DONE--Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE--Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //DONE--
            //In ICompany            
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            var car = new Car() { Make = "Chevrolet", Slogan = "Find New Roads!" };

            var truck = new Truck();
            truck.Make = "Ford";
            truck.Slogan = "Built Ford Tough";

            var suv = new SUV(4.6, "Kia", 4);



            List<IVehicle> listofVehicles = new List<IVehicle>(); 
            
            listofVehicles.Add(truck);
            listofVehicles.Add(suv);
            listofVehicles.Add(car);

            foreach (var v in listofVehicles)
            {

                Console.WriteLine($"This vehicle is a {v.Make}" );
                Console.WriteLine($"This vehicle is a {v.Year}");
                Console.WriteLine($"Their slogan is {v.Slogan}");
                Console.WriteLine($"This has a {v.EngineSize} ");
                Console.WriteLine();




            }

        }
    }
}
