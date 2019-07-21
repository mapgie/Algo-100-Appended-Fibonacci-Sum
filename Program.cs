using System;
using Algo_100__Appended_Fibonacci_Sum.Maths;

/*
    Made on 20/21 July 2019 day 3 & 4 of learning C#.
    Learning exercise based on the following exercise for HSCTF 3.
 
    Writer: Jakob Degen
Find the last nine digits of the sum of the sequence of numbers created by appending the first n fibonacci numbers, where n ranges from 1 to 50. (The Fibonacci Sequence begins with 1, 1, 2 for the purpose of this problem.) For instance, here are the first few appended Fibonacci numbers:
1, 11, 112, 1123, 11235, 112358, 11235813, ...
You should be adding up the first 50 of these. */

namespace Algo_100___Appended_Fibonacci_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 50;

            Console.WriteLine(@"::: The Appended Fibonacci Sum Program :::
This program will do the following:

- Ask you to input an integer n
- Return the first n numbers of the Fibonacci sequence
- Append each Fibonacci number to the set of the previous, such as: 1, 11, 112, 1123, ... to a total of n numbers
- Sum each of the appended numbers
- Return the last 9 numbers of this sequence (provided n > 9).

For the sake of a more interesting result, consider picking a number greater than 9. (I suggest 50).");

            try
            {
                do
                {
                    Console.Write("Input a positive integer, n:");
                    n = Convert.ToInt32(Console.ReadLine());

                } while (n <= 0); 

            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("Invalid input; n set to 50.");
                    n = 50;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                }
            }



            
            var range = new FibonacciCreator();
            range.N = n;
            range.MakeFib();
            range.Append();

            Console.WriteLine("(c) Mapgie 2019");
            Console.ReadKey(true);
            
        }
    }
}
