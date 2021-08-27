using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class CustomallExt
    {
        public static bool CustomAllExt<T>(this IEnumerable<T> enumerable, Func<T, bool> func)
        {

            foreach (var n in enumerable)
            {
                if (!func(n))
                    return false;
            }


            return true;
        }

    }
}
