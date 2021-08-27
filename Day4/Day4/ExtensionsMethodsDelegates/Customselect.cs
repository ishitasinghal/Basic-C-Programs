using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class Customselect
    {
        public static IEnumerable<TResult> ExtCustomSelect<T, TResult>(this IEnumerable<T> enumerable, Func<T, TResult> func)
        {
            if (enumerable is null)
                throw new ArgumentNullException(nameof(enumerable));


            foreach (var elem in enumerable)
            {
                yield return func(elem);
            }
        }

    }
}
