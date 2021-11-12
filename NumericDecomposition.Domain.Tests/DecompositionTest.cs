using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumericDecomposition.Domain.Tests
{
    [TestClass]
    public class DecompositionTest
    {
        [TestMethod]
        public void Decomposition_Should_Not_Trigger_Exception_When_Receives_A_Valid_Number()
        {
            //Arrange
            var number = 45;

            //Act
            var decomposition = new Decomposition(number);

            //Assert
            Assert.IsFalse(decomposition.has_error);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void Decomposition_Should_Trigger_Exception_When_Receives_A_Invalid_Number(int number)
        {
            //Act
            var decomposition = new Decomposition(number);

            //Assert
            Assert.IsTrue(decomposition.has_error);
        }
    }
}
