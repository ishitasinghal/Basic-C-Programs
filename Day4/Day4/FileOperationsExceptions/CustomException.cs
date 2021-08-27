using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day4.FileOperationsExceptions
{
    class ChanceToPlay : Exception
    {
        public ChanceToPlay(string expmsg)
            : base(expmsg)
        {

        }
    }
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(string msg)
            : base(msg)
        {
        }
    }
    class CustomException
    {
        public bool CheckEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        public bool CheckOdd(int n) 
        {
            if (n % 2 == 1)
                return true;
            else
                return false;
        }

        public bool CheckPrime(int n)
        {
            int c = 0;
            for (int j = 1; j < n/2; j++)
            {
                if (n % j == 0)
                    c++;
            }
            if (c == 1)
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckNegative(int n)
        {
            if (n < 0)
                return true;
            else
                return false;
        }

        public bool CheckZero(int n)
        {
            if (n == 0)
                return true;
            else
                return false;
        }



        public CustomException()
        {
            
            try
            {
                int c = 1;
                int num;
                
                do
                {
                    Console.WriteLine("Enter any number form 1-5");
                    num = int.Parse(Console.ReadLine());

                    if (num < 1 || num > 5) {
                        throw new InvalidNumberException("Invalid number exception");
                        
                    }
                    

                    else if (c == 6) {
                        throw new ChanceToPlay("You have played the game 5 times");
                    }
                    


                    else if (num == 1)
                    {
                        Console.WriteLine("Enter even number");
                        int evenNum = int.Parse(Console.ReadLine());
                        if (CheckEven(evenNum))
                            Console.WriteLine("The answer is correct!");
                        else
                            Console.WriteLine("The answer is incorrect!");
                        c++;
                        continue;
                    }

                    else if (num == 2)
                    {
                        Console.WriteLine("Enter odd number");
                        int oddNum = int.Parse(Console.ReadLine());
                        if (CheckOdd(oddNum))
                            Console.WriteLine("The answer is correct!");
                        else
                            Console.WriteLine("The answer is incorrect!");
                        c++;
                        continue;
                    }

                    else if (num == 3)
                    {
                        Console.WriteLine("Enter prime number");
                        int primeNum = int.Parse(Console.ReadLine());
                        if (CheckPrime(primeNum))
                            Console.WriteLine("The answer is correct!");
                        else
                            Console.WriteLine("The answer is incorrect!");
                        c++;
                        continue;
                    }

                    else if (num == 4)
                    {
                        Console.WriteLine("Enter negative number");
                        int negativeNum = int.Parse(Console.ReadLine());
                        if (CheckNegative(negativeNum))
                            Console.WriteLine("The answer is correct!");
                        else
                            Console.WriteLine("The answer is incorrect!");
                        c++;
                        continue;
                    }

                    else if (num == 5)
                    {
                        Console.WriteLine("Enter zero number");
                        int zeroNum = int.Parse(Console.ReadLine());
                        if (CheckZero(zeroNum))
                            Console.WriteLine("The answer is correct!");
                        else
                            Console.WriteLine("The answer is incorrect!");
                        c++;
                        continue;
                    }


                }
                while (num >= 1 && num <= 5 && c <= 5);

                


                
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ChanceToPlay cp)
            {
                Console.WriteLine(cp);
                
            }

            catch (InvalidNumberException ie)
            {
                Console.WriteLine(ie);

            }

            
            Console.ReadKey();

        }

    }
}

