using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NotEqualValidationRuleTests
{
    [TestClass]
    public class NotEqualValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            NotEqualValidationRule<int> validationRule = new NotEqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(5);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("Argument value 5 is not equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            NotEqualValidationRule<int> validationRule = new NotEqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(3);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is equal to 3.", result.Message);
        }
    }
}