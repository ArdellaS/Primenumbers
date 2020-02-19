using System;
using System.Collections.Generic;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter a number to see if its a prime: ");
                long a = long.Parse(Console.ReadLine());

                var result = Maths.IsPrime(a);

                if (result == 0)
                {
                    Console.WriteLine($"{a} is not a prime.");

                }
                else
                {
                    Console.WriteLine($"{a} is a prime.");

                }
            }
        }
    }
}
