using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NotEmptyGuidValidationRuleTests
{
    [TestClass]
    public class NotEmptyGuidValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsNotGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.NewGuid();

            // Act.
            IValidationResult result = NotEmptyGuidValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(string.Format("Argument value '{0}' is not Guid.Empty.", value), result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.Empty;

            // Act.
            IValidationResult result = NotEmptyGuidValidationRule.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is Guid.Empty.", result.Message);
        }
    }
}