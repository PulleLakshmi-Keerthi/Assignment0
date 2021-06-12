using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
                int i, fact = 1, Inputnumber;
                Console.Write("Enter any Number: ");
            Inputnumber = int.Parse(Console.ReadLine());
                for (i = 1; i <= Inputnumber; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + Inputnumber + " is: " + fact);
            }
        }
    }
    
