using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Extensions.ArgumentExtensionsTests
{
    [TestClass]
    public class ToValidatableArgument_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenArgumentIsNull()
        {
            // Arrange.
            IArgument<int> argument = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                argument.ToValidatableArgument();
            }, "@argument");
        }

        [TestMethod]
        public void ReturnTheSameInstance_WhenArgumentIsValidatableArgument()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            IValidatableArgument<int> validatableArgument = argument.ToValidatableArgument();

            // Assert.
            Assert.AreSame(argument, validatableArgument);
        }

        [TestMethod]
        public void ReturnNewValidatableArgumentInstance_WhenArgumentIsNotValidatableArgument()
        {
            // Arrange.
            IArgument<int> argument = new IntArgumentMock();

            // Act.
            IValidatableArgument<int> validatableArgument = argument.ToValidatableArgument();

            // Assert.
            Assert.AreNotSame(argument, validatableArgument);
            Assert.AreEqual(argument.Name, validatableArgument.Name);
            Assert.AreEqual(argument.Value, validatableArgument.Value);
        }
    }
}