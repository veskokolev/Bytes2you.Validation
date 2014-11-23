using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoublePredicates.DoubleNotPositiveInfinityValidationPredicateTests
{
    [TestClass]
    public class DoubleNotPositiveInfinityValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNumber()
        {
            // Arrange.
            double value = 5;

            // Act.
            IValidationPredicateResult result = DoubleNotPositiveInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value {0} is not PositiveInfinity.", value), result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsDoubleNegativeInfinity()
        {
            // Arrange.
            double value = double.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = DoubleNotPositiveInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value {0} is not PositiveInfinity.", value), result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsDoublePositiveInfinity()
        {
            // Arrange.
            double value = double.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = DoubleNotPositiveInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is PositiveInfinity.", result.Message);
        }
    }
}