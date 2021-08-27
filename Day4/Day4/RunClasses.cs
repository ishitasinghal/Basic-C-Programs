using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4.EventsAndDelegates;
using Day4.FileOperationsExceptions;
using Day4.ExtensionsMethodsDelegates;

namespace Day4
{
    class RunClasses
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to run Lamda and delegates program");
            Console.WriteLine("Enter 2 to run Events program");
            Console.WriteLine("Enter 3 to run program on extension methods on integer");
            Console.WriteLine("Enter 4 to run program on extension methods on enumerables");
            Console.WriteLine("Enter 5 to run program on file operations");
            Console.WriteLine("Enter 6 to run program on exceptions");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Running case 1....");
                    LamdaDelegates lamdel = new LamdaDelegates();
                    break;

                case "2":
                    Console.WriteLine("Running case 2....");
                    Inventory iv = new Inventory();
                    

                    break;

                case "3":
                    Console.WriteLine("Running case 3....");
                    ExtensionOnInt exint = new ExtensionOnInt();
                    break;

                case "4":
                    Console.WriteLine("Running case 4....");
                    ExtensionOnEnumerable exenum = new ExtensionOnEnumerable();
                    break;

                case "5":
                    Console.WriteLine("Running case 5....");
                    FileOperations fileop = new FileOperations();
                    break;

                case "6":
                    Console.WriteLine("Running case 6....");
                    CustomException custexp = new CustomException();
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }

}
