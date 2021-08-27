using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class Tresmin
    {
        public static Res ExtCustomMin<T, Res>(this IEnumerable<T> enumerable, Func<T, Res> func) where Res : IComparable<Res>
        {
            if (enumerable is null)
                throw new ArgumentNullException(nameof(enumerable));


            Res min;


            var enumerator = enumerable.GetEnumerator();
            if (enumerator.MoveNext())
            {
                min = func(enumerator.Current);
            }
            else throw new InvalidOperationException("Sequence contains no elements");

            return min;
        }
    }
}
