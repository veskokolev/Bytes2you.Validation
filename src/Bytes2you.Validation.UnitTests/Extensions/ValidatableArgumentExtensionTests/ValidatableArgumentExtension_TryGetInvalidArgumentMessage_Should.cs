using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ValidatableArgumentExtensionTests
{
    [TestClass]
    public class ValidatableArgumentExcensions_TryGetInvalidArgumentMessage_Should
    {
        [TestMethod]
        public void ThrowException_WhenValidatableArgumentIsNull()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = null;

            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    string invalidArgumentMessage;
                    validatableArgument.TryGetInvalidArgumentMessage(out invalidArgumentMessage);
                }, "@validatableArgument");
        }

        [TestMethod]
        public void ReturnsFalse_WhenValidatableArgumentIsValid()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsLessThan(2).IsGreaterThan(5);

            // Act.
            string invalidArgumentMessage;
            bool result = validatableArgument.TryGetInvalidArgumentMessage(out invalidArgumentMessage);

            // Assert.
            Assert.IsFalse(result);
            Assert.AreEqual(string.Empty, invalidArgumentMessage);
        }

        [TestMethod]
        public void ReturnsTrueAndProperMessage_WhenValidatableArgumentIsInvalid()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsGreaterThan(2).IsLessThan(5);

            // Act.
            string invalidArgumentMessage;
            bool result = validatableArgument.TryGetInvalidArgumentMessage(out invalidArgumentMessage);

            // Assert.
            Assert.IsTrue(result);
            Assert.AreEqual("Invalid argument:\n - Argument value 3 is greater than 2.\r\n - Argument value 3 is less than 5.\r\n", invalidArgumentMessage);
        }
    }
}