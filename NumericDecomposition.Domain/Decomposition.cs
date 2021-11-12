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
        public bool has_invalid_number { get; private set; }

        public Decomposition(int number)
        {
            if (number < 1)
                this.has_invalid_number = true;
            else
            {
                this.has_invalid_number = false;
                this.number = number;
                this.divisors = number.GetDivisors();
                this.prime_divisors = number.GetPrimeDivisors();
            }
        }
    }
}
