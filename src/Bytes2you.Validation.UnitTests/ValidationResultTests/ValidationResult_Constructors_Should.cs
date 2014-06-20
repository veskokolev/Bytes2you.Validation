using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationResultTests
{
    [TestClass]
    public class ValidationResult_Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenMessageIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidationResult result = new ValidationResult(true, null);
            }, "message");
        }

        [TestMethod]
        public void ThrowException_WhenMessageIsEmpty()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidationResult result = new ValidationResult(true, string.Empty);
            }, "message");
        }

        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            bool isValid = true;
            string message = "message";

            // Act.
            ValidationResult result = new ValidationResult(isValid, message);

            // Assert.
            Assert.AreEqual(isValid, result.IsValid);
            Assert.AreEqual(message, result.Message);
        }
    }
}