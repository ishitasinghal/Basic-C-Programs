using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    class ExtensionOnInt
    {
        public ExtensionOnInt()
        {
            Console.WriteLine("Enter number to apply on extensions");
            string numb = Console.ReadLine();
            int number = int.Parse(numb);
            Console.WriteLine("Enter 1 to use odd extension");
            Console.WriteLine("Enter 2 to use even extension");
            Console.WriteLine("Enter 3 to use prime extension");
            Console.WriteLine("Enter 4 to use divisible extension");

            string extchoice = Console.ReadLine();

            switch (extchoice)
            {
                case "1":
                    Console.WriteLine("Using odd extension, the result is : " + number.IsOdd());
                    break;

                case "2":
                    Console.WriteLine("Using even extension, the result is : " + number.IsEven());
                    break;

                case "3":
                    Console.WriteLine("Using prime extension, the result is : " + number.IsPrime());
                    break;

                case "4":
                    Console.WriteLine("Enter dividend");
                    string div = Console.ReadLine();
                    int divident = int.Parse(div);
                    Console.WriteLine("Using divisible extension, the result is : " + number.IsDivisible(divident));
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;


            }

            Console.ReadKey();

        }
    }
}
