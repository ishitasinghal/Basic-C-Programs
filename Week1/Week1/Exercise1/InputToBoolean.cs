using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Exercise1
{
    /// <summary>
    /// variuous methods to convert the string input into boolean datatype
    /// </summary>
    class InputToBoolean
    {
        public InputToBoolean()
        {
            Console.WriteLine("Enter any boolean value that is true or false only");
            string bval = Console.ReadLine();

            //method 1: using bool.Parse
            bool bval1 = bool.Parse(bval);
            Console.WriteLine("Converted value : " + bval1);

            //method 2 : using Convert.ToBool
            bool bval2 = Convert.ToBoolean(bval);
            Console.WriteLine("MEthod 2" + bval2);

            // method 3
            bool a;
            if (Boolean.TryParse(bval, out a))
            {

            }

        }

    }
}
