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
            //Arrange
            var number = 45;
            var correctDivisors = new List<int> { 45, 15, 9, 5, 3, 1 };

            //Act
            var divisors = number.GetDivisors();

            //Assert
            CollectionAssert.AreEqual(correctDivisors, divisors);
        }

        [TestMethod]
        public void GetPrimeDivisors_Should_Return_Prime_Divisors_Of_Extended_Number()
        {
            //Arrange
            var number = 45;
            var correctDivisors = new List<int> { 5, 3, 1 };

            //Act
            var primeDivisors = number.GetPrimeDivisors();

            //Assert
            CollectionAssert.AreEqual(correctDivisors, primeDivisors);
        }

        [TestMethod]
        public void GetDivisors_Should_Return_A_Empty_List_When_Extended_Number_Is_Zero()
        {
            //Arrange
            var number = 0;

            //Act
            var divisors = number.GetDivisors();

            //Assert
            Assert.AreEqual(0, divisors.Count);
        }

        [TestMethod]
        public void GetPrimeDivisors_Should_Return_A_Empty_List_When_Extended_Number_Is_Zero()
        {
            //Arrange
            var number = 0;

            //Act
            var primeDivisors = number.GetPrimeDivisors();

            //Assert
            Assert.AreEqual(0, primeDivisors.Count);
        }
    }
}
