using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatPredicates.FloatNotNaNValidationPredicateTests
{
    [TestClass]
    public class FloatNotNaNValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotFloatNaN()
        {
            // Arrange.
            float value = 5;

            // Act.
            IValidationPredicateResult result = FloatNotNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value {0} is not NaN.", value), result.Message);
            
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsDoubleNaN()
        {
            // Arrange.
            float value = float.NaN;

            // Act.
            IValidationPredicateResult result = FloatNotNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is NaN.", result.Message);
        }
    }
}