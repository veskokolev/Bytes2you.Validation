using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.LessThanValidationPredicateTests
{
    [TestClass]
    public class LessThanValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            LessThanValidationPredicate<int> validationPredicate = new LessThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value 2 is less than 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            LessThanValidationPredicate<int> validationPredicate = new LessThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value 3 is greater than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            LessThanValidationPredicate<int> validationPredicate = new LessThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value 4 is greater than or equal to 3.", result.Message);
        }
    }
}