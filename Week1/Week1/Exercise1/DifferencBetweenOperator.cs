using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Exercise1
{
    /// <summary>
    /// The program shows the difference between the three equality checkers
    /// </summary>
    class DifferencBetweenOperator
    {
        public DifferencBetweenOperator()
        {
            Console.WriteLine("Enter two strings to check");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            object obj1 = s1;
            object obj2 = s2;

            Console.WriteLine(" == operator result is { 0 } can't be invoked on a null" + s1 == s2);
            Console.WriteLine("result for .Equals takes one argumnent and can be null"+ s1.Equals(s2));
            Console.WriteLine("output for reference equals takes two arguments, either can be null "+ Object.ReferenceEquals(obj1, obj2));
            Console.ReadLine();
        }

    }
}
