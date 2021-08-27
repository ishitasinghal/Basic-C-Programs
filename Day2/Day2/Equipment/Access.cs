using System;

namespace Day2.Equipment
{
    /// <summary>
    /// base class containing the common properties
    /// </summary>

    class Access
    {
        /// <summary>
        /// method to drive the program
        /// </summary>
        public Access()
        {
            Mobile mb = new Mobile();
            _ = new Immobile();

            Console.WriteLine("Enter 0 for mobile and 1 for immobile ");
            string ch = Console.ReadLine();
            if (ch == "0")
            {
                Console.WriteLine("Enter the equipment name");
                mb.name = Console.ReadLine();
                Console.WriteLine("Enter the description about the equipment");
                mb.description = Console.ReadLine();
                Console.WriteLine("Enter distance travelled by the equipment");
                string dist = Console.ReadLine();
                double d = double.Parse(dist);
                Console.WriteLine("Enter the number of wheels of the equipment");
                string wh = Console.ReadLine();
                double wheels = double.Parse(wh);
                mb.MoveBy(wheels, d);
                mb.ShowDetails();

            }
            else if (ch == "1")
            {
                Console.WriteLine("Enter the equipment name");
                mb.name = Console.ReadLine();
                Console.WriteLine("Enter the description about the equipment");
                mb.description = Console.ReadLine();
                Console.WriteLine("Enter distance travelled by the equipment");
                string dist = Console.ReadLine();
                double d = double.Parse(dist);
                Console.WriteLine("Enter the weight of the equipment");
                string weigh = Console.ReadLine();
                double weight = double.Parse(weigh);
                mb.MoveBy(weight, d);
                mb.ShowDetails();

            }

            else
            {
                Console.WriteLine("wrong choice");

            }


            Console.ReadLine();
        }
    }


}


