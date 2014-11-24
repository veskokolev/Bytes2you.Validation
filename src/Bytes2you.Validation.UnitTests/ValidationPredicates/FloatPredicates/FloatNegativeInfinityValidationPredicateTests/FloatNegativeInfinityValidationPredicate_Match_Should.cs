using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatPredicates.FloatNegativeInfinityValidationPredicateTests
{
    [TestClass]
    public class FloatNegativeInfinityValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsFloatNegativeInfinity()
        {
            // Arrange.
            float value = float.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = FloatNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is -Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsFloatPositiveInfinity()
        {
            // Arrange.
            float value = float.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = FloatNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Infinity> is not -Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNumber()
        {
            // Arrange.
            float value = 5;

            // Act.
            IValidationPredicateResult result = FloatNegativeInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not -Infinity.", result.Message);
        }
    }
}