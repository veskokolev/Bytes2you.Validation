using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.GreaterThanValidationRuleTests
{
    [TestClass]
    public class GreaterThanValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            GreaterThanValidationRule<int> validationRule = new GreaterThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 2 is less than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            GreaterThanValidationRule<int> validationRule = new GreaterThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 3 is less than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            GreaterThanValidationRule<int> validationRule = new GreaterThanValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Argument value 4 is greater than 3.", result.Message);
        }
    }
}