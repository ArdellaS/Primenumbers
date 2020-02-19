using System;
using Xunit;
using Primes;

namespace PrimeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,2)]
        [InlineData(797, 797)]
        public void ISPrime(long a, long expected)
        {
         
            long result = Maths.IsPrime(a);

            Assert.Equal(expected, result);
        }
    }
}
