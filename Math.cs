using System;
using System.Numerics;

/* Learning reflection: This is not a neatly-made program. If it were, class Append() would not duplicate most of class MakeFib(); the return type of MakeFib() is currently empty, meaning that the variables I've created cannot be used outside of the method MakeFib(), hence the essential duplication of the class. As this is a learning exercise, the focus has been on the output being correct.

Additionally, there would be a third class i.e. FindFlag() that would handle the isolation of the flag element at the end.
 */
 
namespace Algo_100__Appended_Fibonacci_Sum.Maths
{
    public class FibonacciCreator
    {
        public long N;

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

            if (N >= 1)
            {
                var i = 3;

                foreach (var n in fibLong)
                {
                    while (i <= N)
                    {
                        fibLong[i] = fibLong[i - 1] + fibLong[i - 2];
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
            var appendedValues = new BigInteger(0);
            var sumOfAppended = new BigInteger(12);

            if (N == 1)
            {
                Console.WriteLine("Appended values = 1");
                Console.WriteLine("Sum of appended values = 1");
            }
            else if (N == 2)
            {
                appendedValues = 11;
                Console.WriteLine("Appended values = 11");
                Console.WriteLine("Sum of appended values = 12");
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

            if (N >= 9)
            {
                var lengthOfSum = sumOfAppended.ToString().Length;
                var chars = sumOfAppended.ToString().ToCharArray(lengthOfSum - 9, 9);
                var flag = new string(chars);
                Console.WriteLine($"You have captured the flag: {flag}");
            }
            else
            {
                Console.WriteLine("Your number was smaller than 9.");
                var chars = sumOfAppended.ToString().ToCharArray();
                var flag = new string(chars);
                Console.WriteLine($"This result is more underwhelming than if you'd picked n = 50: {flag}");
            }

          







        }

    }
}
