using System;
using System.Linq;
using System.IO;
using System.Numerics;

namespace Algo_100__Appended_Fibonacci_Sum.Maths
{
    class FibonacciCreator
    {
        public int N;

        public void MakeFib()
        {

            var fibLong = new long[N+2];

            fibLong[0] = 0; //array is 0-indexed 
            var a = fibLong[1] = 1;
            var b = fibLong[2] = 1;

            if (N == 1)
            {
                Console.WriteLine($"n = 1; Fib(n) = {fibLong[N]}");
            }
            else if (N == 2)
            {
                Console.WriteLine($"n = 1; Fib(n) = {fibLong[N - 1]}");
                Console.WriteLine($"n = 2; Fib(n) = {fibLong[N]}");
            }
            else
            {
                Console.WriteLine($"n = 1; Fib(n) = {a}");
                Console.WriteLine($"n = 2; Fib(n) = {b}");

                var i = 3;

                foreach (var n in fibLong)
                {
                    while (i <= N)
                    {
                        fibLong[i] = fibLong[i - 1] + fibLong[i - 2];
                        Console.WriteLine($"i = {i}; Fib(n) = {fibLong[i]}");
                        ++i;
                    }
                }
            }

        }

        public void Append()
        {
            #region replicaOfMakeFib
            //terrible approach. Think about better way later. 

            var fibLong = new long[N + 2];

            fibLong[0] = 0; //array is 0-indexed 
            var a = fibLong[1] = 1;
            var b = fibLong[2] = 1;

            if (N == 1)
            {
                //Console.WriteLine($"n = 1; Fib(n) = {finDoubles[N]}");
            }
            else if (N == 2)
            {
                //Console.WriteLine($"n = 1; Fib(n) = {finDoubles[N - 1]}");
                //Console.WriteLine($"n = 2; Fib(n) = {finDoubles[N]}");
            }
            else
            {
                //Console.WriteLine($"n = 1; Fib(n) = {a}");
                //Console.WriteLine($"n = 2; Fib(n) = {b}");

                var i = 3;

                foreach (var n in fibLong)
                {
                    while (i <= N)
                    {
                        fibLong[i] = fibLong[i - 1] + fibLong[i - 2];
                        //Console.WriteLine($"i = {i}; Fib(n) = {finDoubles[i]}");
                        ++i;
                    }
                }
            }
            #endregion 
            
            Console.WriteLine("");
            Console.Write($"Fibonacci sequence number {N}: {fibLong[N]}");
            Console.WriteLine("");
            Console.WriteLine("Now we want to append this number to all the previous fib sequence numbers:");

            var j = 3;
            BigInteger appendedValues = new BigInteger(0);
            BigInteger sumOfAppended = new BigInteger(12);

            if (N == 1)
            {
                Console.WriteLine("Appended values = 1");
                Console.WriteLine("Sum of Appended values = 1");
            }
            else if (N == 2)
            {
                appendedValues = 11;
                Console.WriteLine("Appended values = 11");
                Console.WriteLine("Appended values = 12");
            }
            else
            {
                appendedValues = 11;
                while (j <= N) //without using '.Append'
                {
                    var exponent = fibLong[j].ToString().Length;
                    var tenToPower = (ulong) Math.Pow(10, exponent);
                    appendedValues *= tenToPower;
                    appendedValues += fibLong[j];
                    sumOfAppended += appendedValues;
                    
                    ++j;
                }
            }

            Console.WriteLine($"N: {N}, Fib[j] {fibLong[j]}, j: {j}");
            Console.WriteLine($"Appended values: {appendedValues}, and sum: {sumOfAppended}");

            var lengthOfSum = sumOfAppended.ToString().Length;
            var chars = sumOfAppended.ToString().ToCharArray(lengthOfSum - 9, 9);
            //Array.Reverse(chars);
            var flag = new string(chars);
            
            Console.WriteLine($"You have captured the flag: {flag}");







        }

    }
}
