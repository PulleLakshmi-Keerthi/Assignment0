using System;
using System.Linq;

namespace OperationsOnaGivenSetOfNumbers
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Enter a list of numbers you want to perform action on seperated by comma (,)");
            string Input = Console.ReadLine();
            string[] InputArray = Input.Split(',');
            int[] Mynum = new int[InputArray.Length];

            for (int i = 0; i < InputArray.Length; i++)
            {
                Mynum[i] = Int32.Parse(InputArray[i]);

            }

            while (true)
            {
                Console.WriteLine("\nselect the operation you want to perform on the numbers ");
                Console.WriteLine("1. To print the maximum number" +
                    "\n2. To print the minimum number" +
                    "\n3. To print the list in ascending order" +
                   "\n4. To print the list in descending order" +
                   "\n5. To print prime numbers if any" +
                   "\n6. To print the sum of numbers" +
                   "\n7. Exit");

                int option = Int32.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.WriteLine($"\n\nthe maximum number in the given list is {Mynum.Max()}");
                        break;
                    case 2:
                        Console.WriteLine($"\n\nthe minimum number in the given list is {Mynum.Min()}");
                        break;
                    case 3:
                        Array.Sort(Mynum);


                        foreach (int i in Mynum)
                        {
                            Console.Write($" {i}");
                        }

                        break;
                    case 4:
                        Array.Sort(Mynum);


                        for (int j = Mynum.Length; j > 0; j--)
                        {
                            Console.Write($" {Mynum[j - 1]}");
                        }
                        break;

                    case 5:

                        int count = 0;
                        Console.WriteLine("the prime numbers int the list are");
                        for (int l = 0; l < Mynum.Length; l++)
                        {
                            count = 0;

                            for (int k = 2; k <= Mynum[l]; k++)
                            {

                                if (Mynum[l] % k == 0)
                                {

                                    count++;
                                }
                            }

                            if (count == 1)
                            {
                                Console.Write($" {Mynum[l]}");

                            }




                        }
                        break;
                    case 6:
                        Console.WriteLine($"\n\nthe sum of numbers in the given list is {Mynum.Sum()}");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }


            }
        }
    }


}




