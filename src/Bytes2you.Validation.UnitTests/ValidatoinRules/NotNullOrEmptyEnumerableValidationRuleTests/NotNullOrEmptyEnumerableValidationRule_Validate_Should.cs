using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NotNullOrEmptyEnumerableValidationRuleTests
{
    [TestClass]
    public class NotNullOrEmptyEnumerableValidationRule_Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentHasElements()
        {
            // Arrange.
            int [] value = new int[] { 3, 4, 5 };

            // Act.
            IValidationResult result = NotNullOrEmptyEnumerableValidationRule<int[]>.Instance.Validate(value);

            // Assert.
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual("The argument has elements.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNull()
        {
            // Arrange.
            int[] value = null;

            // Act.
            IValidationResult result = NotNullOrEmptyEnumerableValidationRule<int[]>.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            int[] value = new int[] {};

            // Act.
            IValidationResult result = NotNullOrEmptyEnumerableValidationRule<int[]>.Instance.Validate(value);

            // Assert.
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}