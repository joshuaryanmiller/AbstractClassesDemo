using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The {GetType().Name} is drivable.");
        }
    }
}
