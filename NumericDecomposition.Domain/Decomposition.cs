using NumericDecomposition.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumericDecomposition.Domain
{
    public class Decomposition
    {
        public int number { get; private set; }
        public List<int> divisors { get; private set; }
        public List<int> prime_divisors { get; private set; }

        public Decomposition(int number)
        {
            if (number < 1)
                throw new ArgumentException("Número informado menor que um");

            this.number = number;
            this.divisors = number.GetDivisors();
            this.prime_divisors = number.GetPrimeDivisors();
        }
    }
}
