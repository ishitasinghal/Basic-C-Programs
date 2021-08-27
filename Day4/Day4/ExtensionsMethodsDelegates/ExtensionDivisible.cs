using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    public static class ExtensionDivisible
    {
        public static bool IsDivisible(this int num, int num2)
        {
            if (num % num2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
