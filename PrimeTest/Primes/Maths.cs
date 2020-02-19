using System;
using System.Collections.Generic;
using System.Text;

namespace Primes
{
    public class Maths
    {
        public static long IsPrime(long a)
        {
            long b = a / 2;
            long c = 0;

            for (int i = 2; i <= b; i++)
            {
                if (a % i == 0)
                {
                    c = 1;
                }
            }
            
            if (c == 0)
            {
                return a;
            }
            else
            {
                return 0;
            }
        }

    }
}
