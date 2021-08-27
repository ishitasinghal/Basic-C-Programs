using System;

namespace Day2.Equipment
{
    /// <summary>
    /// derived class from base equipment class
    /// </summary>
    class Immobile : Equipment
    {
        public override void MoveBy(double wt, double b)
        {
            base.MoveBy(wt, b);
            distanceMoved += b;
            maintenanceCost = wt * b;

        }

        public void ShowDetails()
        {
            Console.WriteLine("Name of the equipment : " + name);
            Console.WriteLine("Description of the equipment : " + description);
            Console.WriteLine("Total Distance moved by the equipment : " + distanceMoved);
            Console.WriteLine("Maintenance cost of the equipment : " + maintenanceCost);
            Console.WriteLine("Name of the equipment : IMMOBILE EQUIPMENT ");
        }
    }
}
