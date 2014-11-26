using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ValidatableArgumentFluentExtensionTests
{
    [TestClass]
    public class TryGetArgumentException_Should
    {
        [TestMethod]
        public void ThrowException_WhenValidatableArgumentIsNull()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = null;

            // Act & Assert.
            ArgumentException argumentException;
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    validatableArgument.TryGetArgumentException(out argumentException);
                }, "@validatableArgument");
        }

        [TestMethod]
        public void ReturnFalseAndArgumentExceptionIsNull_WhenArgumentDoesNotHaveMatches()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsLessThan(2).IsGreaterThan(5);

            // Act.
            ArgumentException argumentException;
            bool result = validatableArgument.TryGetArgumentException(out argumentException);

            // Assert.
            Assert.IsFalse(result);
            Assert.IsNull(argumentException);
        }

        [TestMethod]
        public void ReturnTrueAndCreatesArgumentException_WhenArgumentHasMatches()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsLessThan(5).IsGreaterThan(2);

            // Act.
            ArgumentException argumentException;
            bool result = validatableArgument.TryGetArgumentException(out argumentException);

            // Assert.
            Assert.IsTrue(result);
            Assert.IsNotNull(argumentException);
            Assert.AreEqual("validatableArgument", argumentException.ParamName);
            Assert.AreEqual("Invalid argument:\n - Argument value <3> is less than <5>.\r\n - Argument value <3> is greater than <2>.\r\n\r\nParameter name: validatableArgument", argumentException.Message);
        }
    }
}