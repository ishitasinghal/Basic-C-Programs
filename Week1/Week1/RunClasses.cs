using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Exercise1;

namespace Week1
{
    /// <summary>
    /// This is the main method class, that runs whichever class the user wants to run.
    /// </summary>
    class RunClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to run Input to integer class");
            Console.WriteLine("Enter 2 to run Input To float class ");
            Console.WriteLine("Enter 3 to run input to Boolean class");
            Console.WriteLine("Enter 4 to run Difference Between Opertors class");
            Console.WriteLine("Enter 5 to run Prime number class");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Case 1 running ....");
                    InputToInt i = new InputToInt();
                    break;
                case "2":
                    Console.WriteLine("Case 2 running....");
                    InputToFloat f = new InputToFloat();
                    break;
                case "3":
                    Console.WriteLine("Case 3 running.... ");
                    InputToBoolean b = new InputToBoolean();
                    break;
                case "4":
                    Console.WriteLine("Case 4 running ....");
                    DifferencBetweenOperator db = new DifferencBetweenOperator();
                    break;
                case "5":
                    Console.WriteLine("Case 5 running....");
                    PrimeNoRange pr = new PrimeNoRange();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;

            }


        }
    }
}
