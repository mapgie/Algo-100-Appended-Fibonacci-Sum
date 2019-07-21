using System;
using System.Runtime.InteropServices;
using Algo_100__Appended_Fibonacci_Sum.Maths;

/* Writer: Jakob Degen
Find the last nine digits of the sum of the sequence of numbers created by appending the first n fibonacci numbers, where n ranges from 1 to 50. (The Fibonacci Sequence begins with 1, 1, 2 for the purpose of this problem.) For instance, here are the first few appended Fibonacci numbers:
1, 11, 112, 1123, 11235, 112358, 11235813, ...
You should be adding up the first 50 of these. */

namespace Algo_100___Appended_Fibonacci_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n:");

            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number; n set to 50.");
                n = 50;
            }

            var range = new FibonacciCreator();
            range.N = n;
            range.MakeFib();
            range.Append();

            Console.ReadKey(true);


        }
    }
}
