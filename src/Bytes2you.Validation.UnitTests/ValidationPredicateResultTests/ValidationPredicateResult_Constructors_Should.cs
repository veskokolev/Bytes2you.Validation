using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicateResultTests
{
    [TestClass]
    public class ValidationPredicateResult_Constructors_Should
    {
        [TestMethod]
        public void ThrowException_WhenMessageIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidationPredicateResult result = new ValidationPredicateResult(true, null);
            }, "message");
        }

        [TestMethod]
        public void ThrowException_WhenMessageIsEmpty()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidationPredicateResult result = new ValidationPredicateResult(true, string.Empty);
            }, "message");
        }

        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            bool isMatch = true;
            string message = "message";

            // Act.
            ValidationPredicateResult result = new ValidationPredicateResult(isMatch, message);

            // Assert.
            Assert.AreEqual(isMatch, result.IsMatch);
            Assert.AreEqual(message, result.Message);
        }
    }
}