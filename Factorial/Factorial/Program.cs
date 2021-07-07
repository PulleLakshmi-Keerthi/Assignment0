using System;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;

            // Because each element in the sequence is a string,
            // not an anonymous type, var is optional here also.
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            }
        }
        }
    }
    
