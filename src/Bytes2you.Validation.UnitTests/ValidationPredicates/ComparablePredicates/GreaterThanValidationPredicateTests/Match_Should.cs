using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.GreaterThanValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            GreaterThanValidationPredicate<int> validationPredicate = new GreaterThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <2> is less than or equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            GreaterThanValidationPredicate<int> validationPredicate = new GreaterThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <3> is less than or equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            GreaterThanValidationPredicate<int> validationPredicate = new GreaterThanValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <4> is greater than <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNullAndArgumentIsNotNull()
        {
            // Arrange.
            string value = "a";
            GreaterThanValidationPredicate<string> validationPredicate = new GreaterThanValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <a> is greater than <null>.", result.Message);
        }


        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNullAndArgumentIsNull()
        {
            // Arrange.
            string value = null;
            GreaterThanValidationPredicate<string> validationPredicate = new GreaterThanValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <null> is less than or equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNotNullAndArgumentIsNull()
        {
            // Arrange.
            string value = null;
            GreaterThanValidationPredicate<string> validationPredicate = new GreaterThanValidationPredicate<string>("a");

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <null> is less than or equal to <a>.", result.Message);
        }
    }
}