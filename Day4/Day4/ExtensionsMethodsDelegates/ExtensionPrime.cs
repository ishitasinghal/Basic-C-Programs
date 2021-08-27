using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    public static class ExtensionPrime
    {
        public static bool IsPrime(this int num)
        {
            int m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
