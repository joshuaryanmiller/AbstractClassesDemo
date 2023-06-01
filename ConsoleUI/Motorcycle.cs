using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is in drive.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle can only be driven if you have a motorcycle endorsement.");
        }
    }
}
