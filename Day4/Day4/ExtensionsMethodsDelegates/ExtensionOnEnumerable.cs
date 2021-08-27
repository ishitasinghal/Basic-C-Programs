using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Day4.ExtensionsMethodsDelegates
{
    class ExtensionOnEnumerable
    {
        public ExtensionOnEnumerable()
        {
            var arr = new int[10] {0, 1, 5, 10, 15, 20, 4, 6, 9, 18};
            Console.WriteLine("The array is : " + arr);
            Console.WriteLine("\nResult for CustomAll : "+ arr.CustomAllExt(x => x > 1));
            Console.WriteLine("\nResult for CustomAny : " + arr.CustomAnyExt(x => x < 0));
            Console.WriteLine("\nResult for CustomMax : " + arr.CustomMaxExt(x => x * 2));
            Console.WriteLine("\nResult for CustomMin : " + arr.ExtCustomMin(x => x - 1));
            Console.WriteLine("\nResult for CustomWhere : " + string.Join(", ", arr.ExtCustomWhere(x => x > 3)));
            Console.WriteLine("\nResult for CustomSelect : " + string.Join(", ", arr.ExtCustomSelect(x => x + 1)));
            Console.ReadKey();
        }
    }
}
