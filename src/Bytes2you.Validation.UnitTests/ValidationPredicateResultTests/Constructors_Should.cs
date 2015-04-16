using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicateResultTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenMessageIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                ValidationPredicateResult result = new ValidationPredicateResult(true, null, ValidationType.Default);
            }, "message");
        }

        [TestMethod]
        public void ThrowArgumentException_WhenMessageIsEmpty()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(() =>
            {
                ValidationPredicateResult result = new ValidationPredicateResult(true, string.Empty, ValidationType.Default);
            }, "message");
        }

        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            bool isMatch = true;
            string message = "message";
            ValidationType validationType = ValidationType.Range;

            // Act.
            ValidationPredicateResult result = new ValidationPredicateResult(isMatch, message, validationType);

            // Assert.
            Assert.AreEqual(isMatch, result.IsMatch);
            Assert.AreEqual(message, result.Message);
            Assert.AreEqual(validationType, result.ValidationType);
        }
    }
}