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
            new Decomposition(45);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void Decomposition_Should_Trigger_Exception_When_Receives_A_Invalid_Number(int number)
        {
            new Decomposition(number);
        }
    }
}
