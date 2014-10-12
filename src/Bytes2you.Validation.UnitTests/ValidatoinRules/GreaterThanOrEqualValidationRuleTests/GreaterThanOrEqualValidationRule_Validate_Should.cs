using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.GreaterThanOrEqualValidationRuleTests
{
    [TestClass]
    public class GreaterThanOrEqualValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsLessThanTheBound()
        {
            // Arrange.
            int value = 2;
            GreaterThanOrEqualValidationRule<int> validationRule = new GreaterThanOrEqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 2 is less than 3.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsEqualToTheBound()
        {
            // Arrange.
            int value = 3;
            GreaterThanOrEqualValidationRule<int> validationRule = new GreaterThanOrEqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Argument value 3 is greater than or equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsGreaterThanTheBound()
        {
            // Arrange.
            int value = 4;
            GreaterThanOrEqualValidationRule<int> validationRule = new GreaterThanOrEqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Argument value 4 is greater than or equal to 3.", result.Message);
        }
    }
}