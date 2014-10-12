using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NullValidationRuleTests
{
    [TestClass]
    public class NullValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNotNull()
        {
            // Arrange.
            object value = new object();

            // Act.
            IValidationResult result = NullValidationRule<object>.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is not null.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsNull()
        {
            // Arrange.
            object value = null;

            // Act.
            IValidationResult result = NullValidationRule<object>.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument is null.", result.Message);
        }
    }
}