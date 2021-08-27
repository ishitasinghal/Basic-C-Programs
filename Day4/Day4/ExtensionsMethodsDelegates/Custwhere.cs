using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class Custwhere
    {
        public static IEnumerable<T> ExtCustomWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> func)
        {
            if (enumerable is null)
                throw new ArgumentNullException(nameof(enumerable));


            foreach (var elem in enumerable)
            {
                if (func(elem))
                    yield return elem;
            }
        }
    }
}
