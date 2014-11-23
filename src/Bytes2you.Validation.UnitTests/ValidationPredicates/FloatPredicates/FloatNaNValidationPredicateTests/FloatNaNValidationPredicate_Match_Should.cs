using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatPredicates.FloatNaNValidationPredicateTests
{
    [TestClass]
    public class FloatNaNValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsFloatNaN()
        {
            // Arrange.
            float value = float.NaN;

            // Act.
            IValidationPredicateResult result = FloatNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is NaN.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotDoubleNaN()
        {
            // Arrange.
            float value = 5;

            // Act.
            IValidationPredicateResult result = FloatNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value {0} is not NaN.", value), result.Message);
        }
    }
}