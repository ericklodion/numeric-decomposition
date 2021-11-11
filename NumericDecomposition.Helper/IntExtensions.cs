using System;
using System.Collections.Generic;

namespace NumericDecomposition.Helper
{
    public static class IntExtensions
    {
        public static List<int> GetDivisors(this int number)
        {
            var divisors = new List<int>();

            for (int i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        public static List<int> GetPrimeDivisors(this int number)
        {
            var divisors = number.GetDivisors();
            var primes = new List<int>();

            foreach (var divisor in divisors)
            {
                var divisor_count = divisor.GetDivisors().Count;
                if (divisor_count == 1 || divisor_count == 2)
                    primes.Add(divisor);
            }

            return primes;
        }
    }
}
