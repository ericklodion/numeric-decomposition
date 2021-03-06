using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumericDecomposition.Domain.Tests
{
    [TestClass]
    public class DecompositionTest
    {
        [TestMethod]
        public void Decomposition_Should_Has_Prop_Invalid_Number_False_When_Receives_A_Valid_Number()
        {
            //Arrange
            var number = 45;

            //Act
            var decomposition = new Decomposition(number);

            //Assert
            Assert.IsFalse(decomposition.has_invalid_number);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void Decomposition_Should_Has_Prop_Invalid_Number_True_When_Receives_A_Invalid_Number(int number)
        {
            //Act
            var decomposition = new Decomposition(number);

            //Assert
            Assert.IsTrue(decomposition.has_invalid_number);
        }
    }
}
