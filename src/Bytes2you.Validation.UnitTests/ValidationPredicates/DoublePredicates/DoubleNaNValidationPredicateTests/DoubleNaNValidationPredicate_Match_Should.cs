using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoubleNaNValidationPredicateTests
{
    [TestClass]
    public class DoubleNaNValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsDoubleNaN()
        {
            // Arrange.
            double value = double.NaN;

            // Act.
            IValidationPredicateResult result = DoubleNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is NaN.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotDoubleNaN()
        {
            // Arrange.
            double value = 5;

            // Act.
            IValidationPredicateResult result = DoubleNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not NaN.", result.Message);
        }
    }
}