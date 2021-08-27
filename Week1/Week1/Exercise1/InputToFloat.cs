using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Exercise1
{
    /// <summary>
    /// different ways to convert string input to float datatype
    /// </summary>
    class InputToFloat
    {
        public InputToFloat()
        {
            Console.WriteLine("Hi User! Enter float input");
            string inp1 = Console.ReadLine();

            //method 1 : using float.Parse
            float finp1 = float.Parse(inp1);
            Console.WriteLine("Float converted : " + finp1);

            //method 2 : using Convert.ToFloat
            float finp2 = (float)Convert.ToDouble(inp1);
            Console.WriteLine("Method 2 : " + finp2);

            // method 3 : using float.TryParse
            bool a;
            float finp3;
            a = float.TryParse(inp1, out finp3);
            Console.WriteLine("Method 3 : It gives whether it canbe converted to a float value or not " + a);

        }

    }
}
