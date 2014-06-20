using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.EqualValidationRuleTests
{
    [TestClass]
    public class EqualValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            EqualValidationRule<int> validationRule = new EqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(3);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            EqualValidationRule<int> validationRule = new EqualValidationRule<int>(3);

            // Act.
            IValidationResult result = validationRule.Validate(5);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("Argument value 5 is not equal to 3.", result.Message);
        }
    }
}