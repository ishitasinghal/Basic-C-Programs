using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Equipment
{
    class Mobile : Equipment
    {
        public override void MoveBy(double n, double b)
        {
            base.MoveBy(n, b);
            distanceMoved = distanceMoved + b;
            maintenanceCost = n * b;

        }

        public void ShowDetails()
        {
            Console.WriteLine("Name of the equipment : " + name);
            Console.WriteLine("Description of the equipment : " + description);
            Console.WriteLine("Total Distance moved by the equipment : " + distanceMoved + "km");
            Console.WriteLine("Maintenance cost of the equipment : " + maintenanceCost + "INR");
            Console.WriteLine("Name of the equipment : MOBILE EQUIPMENT ");
        }



    }
}
