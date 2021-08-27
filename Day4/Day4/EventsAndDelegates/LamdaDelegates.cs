using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.EventsAndDelegates
{
    class LamdaDelegates

{
        //method to display the details
    public static void Display(string message, IEnumerable<int> list)
    {
        Console.Write(message + " :   ");
        foreach (int num in list)
            Console.Write(num + "  ");
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }

        public static bool IsBigger(int x)
        {
            return(x > 5);
        }
        public static bool IsSmaller(int x)
        {
            return x < 5;
        }

        public static bool MethodforAll(int x)
        {
            return x != 0;
        }
        public LamdaDelegates()
    {
        List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        IEnumerable<int> odd = list.Where(x => x % 2 == 1); //even without curly brackets  
        Display("Odd", odd);

        IEnumerable<int> even = list.Where(x => { return x % 2 == 0; }); //even with curly brackets
        Display("Even", even);

        IEnumerable<int> primeno = list.Where(delegate (int x) { //prime numbers using delegates
            if (x <= 1)
                return false;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return false;
            return true;
        });
        Display("Primes using delegate", primeno);

            //prime number using lamda function
            IEnumerable<int> primesAnother = list.Where(x =>
            {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });
            Display("Prime number using lamda function", primesAnother);

            //using Func inbuilt delegate
            Func<int, bool> IsBiggerdDelegate = IsBigger;   
        IEnumerable<int> res = list.Where(IsBiggerdDelegate);
        Display("The  number is bigger than 5: ", res);

        Func<int, bool> IsSmallerDelegate = new Func<int, bool>(IsSmaller);
        IEnumerable<int> r = list.Where(IsSmallerDelegate);
        Display("The  number is smaller than 5: ", r);

        Func<int, bool> Mult3 = new Func<int, bool>(y => y % 3 == 0);//creating a delegate object
        IEnumerable<int> re = list.Where(Mult3);
        Display("3k", re);

            
            Func<int, bool> exp3k1 = new Func<int, bool>(delegate (int x) {
            return x % 3 == 1;
        });
        IEnumerable<int> list1 = list.Where(exp3k1);
        Display("REsult for 3k + 1", list1);

            Func<int, bool> exp3k2 = x => x % 3 == 2;
        IEnumerable<int> list2 = list.Where(exp3k2);
        Display("REsult for 3k + 2", list2);

            Func<int, bool> any = delegate (int x) {
            return x != 0;
        };
        IEnumerable<int> anylist = list.Where(any);
        Display("Result for anonymous method assignment", anylist);

            Func<int, bool> any2 = MethodforAll;
        IEnumerable<int> anylist2 = list.Where(any2);
        Display("Result for anything", anylist2);
    }

   

    
  

}
}