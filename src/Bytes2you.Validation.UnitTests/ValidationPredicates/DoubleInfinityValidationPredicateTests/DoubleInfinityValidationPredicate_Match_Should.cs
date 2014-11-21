using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoubleInfinityValidationPredicateTests
{
    [TestClass]
    public class DoubleInfinityValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsDoublePositiveInfinity()
        {
            // Arrange.
            double value = double.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = DoubleInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsDoubleNegativeInfinity()
        {
            // Arrange.
            double value = double.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = DoubleInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNotDoubleInfinity()
        {
            // Arrange.
            double value = 5;

            // Act.
            IValidationPredicateResult result = DoubleInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value '{0}' is not Infinity.", value), result.Message);
        }
    }
}