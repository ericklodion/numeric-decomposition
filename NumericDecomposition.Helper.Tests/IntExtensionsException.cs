using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NumericDecomposition.Helper.Tests
{
    [TestClass]
    public class IntExtensionsException
    {
        [TestMethod]
        public void GetDivisors_Should_Return_Divisors_Of_Extended_Number()
        {
            var number = 45;
            var correctDivisors = new List<int> { 45, 15, 9, 5, 3, 1 };

            var divisors = number.GetDivisors();

            CollectionAssert.AreEqual(correctDivisors, divisors);
        }

        [TestMethod]
        public void GetPrimeDivisors_Should_Return_Prime_Divisors_Of_Extended_Number()
        {
            var number = 45;
            var correctDivisors = new List<int> { 5, 3, 1 };

            var primeDivisors = number.GetPrimeDivisors();

            CollectionAssert.AreEqual(correctDivisors, primeDivisors);
        }
    }
}
