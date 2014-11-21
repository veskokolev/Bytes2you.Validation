using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GreaterThanOrEqualValidationPredicateTests
{
    [TestClass]
    public class GreaterThanOrEqualValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            GreaterThanOrEqualValidationPredicate<int> validationPredicate = new GreaterThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value 2 is less than 3.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            GreaterThanOrEqualValidationPredicate<int> validationPredicate = new GreaterThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value 3 is greater than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            GreaterThanOrEqualValidationPredicate<int> validationPredicate = new GreaterThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value 4 is greater than or equal to 3.", result.Message);
        }
    }
}