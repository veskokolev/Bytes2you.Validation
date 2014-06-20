using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NullOrEmptyStringValidationRuleTests
{
    [TestClass]
    public class NullOrEmptyStringValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentHasElements()
        {
            // Arrange.
            string value = "asdf";

            // Act.
            IValidationResult result = NullOrEmptyStringValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is neither null nor empty.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsNull()
        {
            // Arrange.
            string value = null;

            // Act.
            IValidationResult result = NullOrEmptyStringValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            string value = string.Empty;

            // Act.
            IValidationResult result = NullOrEmptyStringValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}