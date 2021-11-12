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
        public bool has_error { get; set; }

        public Decomposition(int number)
        {
            if (number < 1)
                this.has_error = true;
            else
            {
                this.has_error = false;
                this.number = number;
                this.divisors = number.GetDivisors();
                this.prime_divisors = number.GetPrimeDivisors();
            }
        }
    }
}
