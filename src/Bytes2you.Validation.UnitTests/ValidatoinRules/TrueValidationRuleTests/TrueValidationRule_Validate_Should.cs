using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.TrueValidationRuleTests
{
    [TestClass]
    public class TrueValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsTrue()
        {
            // Arrange.
            bool value = true;

            // Act.
            IValidationResult result = TrueValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is true.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsFalse()
        {
            // Arrange.
            bool value = false;

            // Act.
            IValidationResult result = TrueValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is false.", result.Message);
        }
    }
}