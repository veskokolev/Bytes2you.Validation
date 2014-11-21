using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatInfinityValidationPredicateTests
{
    [TestClass]
    public class FloatInfinityValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsFloatPositiveInfinity()
        {
            // Arrange.
            float value = float.PositiveInfinity;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsFloatNegativeInfinity()
        {
            // Arrange.
            float value = float.NegativeInfinity;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Infinity.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNotFloatInfinity()
        {
            // Arrange.
            float value = 5;

            // Act.
            IValidationPredicateResult result = FloatInfinityValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value '{0}' is not Infinity.", value), result.Message);
        }
    }
}