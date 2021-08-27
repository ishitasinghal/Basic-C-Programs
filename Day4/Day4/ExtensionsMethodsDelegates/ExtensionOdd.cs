using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ExtensionsMethodsDelegates
{
    public static class ExtensionOdd
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        } 
    }
}
