using Day2.Equipment;
using Day2.DuckFolder;
using System;

namespace Day2
{
    /// <summary>
    /// main method to run classes
    /// </summary>
    class RunClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to run Equipment class");
            Console.WriteLine("Enter 2 to run Duck class");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Running Eqipment Class");
                    Access ac = new Access();
                    break;
                case "2":
                    Console.WriteLine("Running Duck class");
                    DuckSimulator du = new DuckSimulator();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
