using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.LessThanValidationRuleTests
{
    [TestClass]
    public class LessThanValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            LessThanValidationRule<int> validationRule = new LessThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Argument value 2 is less than 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            LessThanValidationRule<int> validationRule = new LessThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 3 is greater than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            LessThanValidationRule<int> validationRule = new LessThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 4 is greater than or equal to 3.", result.Message);
        }
    }
}