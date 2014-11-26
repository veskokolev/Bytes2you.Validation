using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.LessThanOrEqualValidationPredicateTests
{
    [TestClass]
    public class LessThanOrEqualValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            LessThanOrEqualValidationPredicate<int> validationPredicate = new LessThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <2> is less than or equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            LessThanOrEqualValidationPredicate<int> validationPredicate = new LessThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <3> is less than or equal to <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            LessThanOrEqualValidationPredicate<int> validationPredicate = new LessThanOrEqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <4> is greater than <3>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenBoundIsNullAndArgumentIsNotNull()
        {
            // Arrange.
            string value = "a";
            LessThanOrEqualValidationPredicate<string> validationPredicate = new LessThanOrEqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <a> is greater than <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNullAndArgumentIsNull()
        {
            // Arrange.
            string value = null;
            LessThanOrEqualValidationPredicate<string> validationPredicate = new LessThanOrEqualValidationPredicate<string>(null);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <null> is less than or equal to <null>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenBoundIsNotNullAndArgumentIsNull()
        {
            // Arrange.
            string value = null;
            LessThanOrEqualValidationPredicate<string> validationPredicate = new LessThanOrEqualValidationPredicate<string>("a");

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <null> is less than or equal to <a>.", result.Message);
        }
    }
}