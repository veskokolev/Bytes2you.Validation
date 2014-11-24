using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoublePredicates.DoubleNegativeInfinityValidationPredicateTests
{
    [TestClass]
    public class DoubleNegativeInfinityValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsDoubleNegativeInfinity()
        {
            // Arrange.
            double value = double.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = DoubleNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is -Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsDoublePositiveInfinity()
        {
            // Arrange.
            double value = double.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = DoubleNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Infinity> is not -Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNumber()
        {
            // Arrange.
            double value = 5;

            // Act.
            IValidationPredicateResult result = DoubleNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not -Infinity.", result.Message);
        }
    }
}