using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car = new Car() { HasTrunk = true, Make = "Tesla", Model = "X", Year = 2023};
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Ural", Model = "Gear Up", Year = 2023};

            Vehicle carboat = new Car() { HasTrunk = true, Make = "MI6", Model = "007", Year = 1977 };
            Vehicle jeep = new Car() { HasTrunk = true, Make = "Jeep", Model = "Wrangler", Year = 2023 };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(carboat);
            vehicles.Add(jeep);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("------------------------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            car.DriveAbstract();
            car.DriveVirtual();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{motorcycle.Make} {motorcycle.Model} {motorcycle.Year}");
            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();
            Console.WriteLine("------------------------------------------------");



            #endregion            
            Console.ReadLine();
        }
    }
}
