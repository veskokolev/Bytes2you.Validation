using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.FalseValidationRuleTests
{
    [TestClass]
    public class FalseValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsFalse()
        {
            // Arrange.
            bool value = false;

            // Act.
            IValidationResult result = FalseValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is false.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsTrue()
        {
            // Arrange.
            bool value = true;

            // Act.
            IValidationResult result = FalseValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is true.", result.Message);
        }
    }
}