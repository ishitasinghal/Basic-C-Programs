using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class CustomanyExt
    {
        public static bool CustomAnyExt<T>(this IEnumerable<T> enumerable, Func<T, bool> func)
        {

            foreach (var elem in enumerable)
            {
                if (func(elem))
                    return true;
            }


            return false;
        }

    }
}
