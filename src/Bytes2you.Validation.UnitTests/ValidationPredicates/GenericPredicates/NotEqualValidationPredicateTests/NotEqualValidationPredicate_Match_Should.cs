using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GenericPredicates.NotEqualValidationPredicateTests
{
    [TestClass]
    public class NotEqualValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            NotEqualValidationPredicate<int> validationPredicate = new NotEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            NotEqualValidationPredicate<int> validationPredicate = new NotEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(3);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNullAndArgumentIsNull()
        {
            // Arrange.
            NotEqualValidationPredicate<string> validationPredicate = new NotEqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNullAndArgumentIsNotNull()
        {
            // Arrange.
            NotEqualValidationPredicate<string> validationPredicate = new NotEqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match("a");

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <a> is not equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNotNullAndArgumentIsNull()
        {
            // Arrange.
            NotEqualValidationPredicate<string> validationPredicate = new NotEqualValidationPredicate<string>("a");

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(null);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <null> is not equal to <a>.", result.Message);
        }
    }
}