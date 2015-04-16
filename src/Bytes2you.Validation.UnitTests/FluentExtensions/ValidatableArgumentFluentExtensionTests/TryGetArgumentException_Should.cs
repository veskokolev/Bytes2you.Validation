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
            Ensure.ArgumentNullExceptionIsThrown(
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
        public void ReturnTrueAndCreatesArgumentOutOfRangeException_WhenArgumentHasMatchesOfRangeValidationType()
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
            Assert.IsInstanceOfType(argumentException, typeof(ArgumentOutOfRangeException));
            Assert.AreEqual("validatableArgument", argumentException.ParamName);
            Assert.AreEqual("Argument value <3> is less than <5>.\r\nParameter name: validatableArgument", argumentException.Message);
        }

        [TestMethod]
        public void ReturnTrueAndCreatesArgumentNullException_WhenArgumentIsNullAndHasMatchesOfDefaultValidationType()
        {
            // Arrange.
            IValidatableArgument<string> validatableArgument = new ValidatableArgument<string>("validatableArgument", null);
            validatableArgument.IsNotEqual("asdf");

            // Act.
            ArgumentException argumentException;
            bool result = validatableArgument.TryGetArgumentException(out argumentException);

            // Assert.
            Assert.IsTrue(result);
            Assert.IsNotNull(argumentException);
            Assert.IsInstanceOfType(argumentException, typeof(ArgumentNullException));
            Assert.AreEqual("validatableArgument", argumentException.ParamName);
            Assert.AreEqual("Argument value <null> is not equal to <asdf>.\r\nParameter name: validatableArgument", argumentException.Message);
        }

        [TestMethod]
        public void ReturnTrueAndCreatesArgumentException_WhenArgumentIsNotNullAndHasMatchesOfDefaultValidationType()
        {
            // Arrange.
            IValidatableArgument<string> validatableArgument = new ValidatableArgument<string>("validatableArgument", "xxx");
            validatableArgument.IsNotEqual("asdf");

            // Act.
            ArgumentException argumentException;
            bool result = validatableArgument.TryGetArgumentException(out argumentException);

            // Assert.
            Assert.IsTrue(result);
            Assert.IsNotNull(argumentException);
            Assert.IsInstanceOfType(argumentException, typeof(ArgumentException));
            Assert.AreEqual("validatableArgument", argumentException.ParamName);
            Assert.AreEqual("Argument value <xxx> is not equal to <asdf>.\r\nParameter name: validatableArgument", argumentException.Message);
        }
    }
}