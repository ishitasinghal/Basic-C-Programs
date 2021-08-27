using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Exercise1
{
    class InputToInt
    {
        /// <summary>
        /// different ways to convert string input to integer data type
        /// </summary>
        public InputToInt()
        {
            Console.WriteLine("Hi User! Enter numeric input");
            string inp1 = Console.ReadLine();

            //method 1 : using int.Parse
            int intinp1 = int.Parse(inp1);
            Console.WriteLine("Method 1 : " + intinp1);

            //method 2 : using Convert.ToInt
            int intinp2 = Convert.ToInt32(inp1);
            Console.WriteLine("Method 2 : " + intinp2);

            //method 3 : using int.TryParse
            bool a;
            int intinp3;
            a = int.TryParse(inp1, out intinp3);
            Console.WriteLine("Method 3 : It gives whether it canbe converted to a numeric value or not " + a);

            Console.ReadKey();
        }

    }
}
