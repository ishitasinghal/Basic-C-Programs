using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Exercise1
{
    class PrimeNoRange
    {
        /// <summary>
        /// This function validates the input nmbers provided 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        static bool Validate(int n1, int n2)
        {
            if (n1 < n2 && n1 > 0 && n2 > 0 && n1 != n2)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Function to print the prime numbers
        /// </summary>
        /// <param name="l"></param>
        /// <param name="k"></param>

        static void prime(int l, int k)
        {
            for (int i = l; i <= k; i++)
            {
                int c = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }

        public PrimeNoRange()
        {
            int u;
            int v;
            bool validated = false;
            do
            {
                Console.WriteLine("Enter two non negative numbers, keeping the first one smaller than the second one");
                string a = Console.ReadLine();
                u = int.Parse(a);
                string b = Console.ReadLine();
                v = int.Parse(b);

                validated = validate(u, v);
            } while (validated == false);

            prime(u, v);


        }

    }
}
