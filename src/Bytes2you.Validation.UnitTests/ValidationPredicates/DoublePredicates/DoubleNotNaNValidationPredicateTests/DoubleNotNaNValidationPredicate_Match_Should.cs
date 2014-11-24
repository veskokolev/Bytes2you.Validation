using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoublePredicates.DoubleNotNaNValidationPredicateTests
{
    [TestClass]
    public class DoubleNotNaNValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotDoubleNaN()
        {
            // Arrange.
            double value = 5;

            // Act.
            IValidationPredicateResult result = DoubleNotNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not NaN.", result.Message);
            
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsDoubleNaN()
        {
            // Arrange.
            double value = double.NaN;

            // Act.
            IValidationPredicateResult result = DoubleNotNaNValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is NaN.", result.Message);
        }
    }
}