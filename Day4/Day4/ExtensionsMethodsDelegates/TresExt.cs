using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    static class TresExt
    {
        public static Res CustomMaxExt<T, Res>(this IEnumerable<T> enumerable, Func<T, Res> func) where Res : IComparable<Res>
        {
            if (enumerable is null)
                throw new ArgumentNullException(nameof(enumerable));


            Res max;


            var enumerator = enumerable.GetEnumerator();
            if (enumerator.MoveNext())
            {
                max = func(enumerator.Current);
            }
            else throw new InvalidOperationException("Sequence contains no elements");
            return max;
        }

    }
}
