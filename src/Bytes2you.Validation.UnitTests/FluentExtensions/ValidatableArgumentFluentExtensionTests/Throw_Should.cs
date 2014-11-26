using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ValidatableArgumentFluentExtensionTests
{
    [TestClass]
    public class Throw_Should
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
                    validatableArgument.Throw();
                }, "@validatableArgument");
        }

        [TestMethod]
        public void NotThrowException_WhenArgumentHasMatches()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsLessThan(2).IsGreaterThan(5);

            // Act & Assert.
            Ensure.NoExceptionIsThrown(
                () =>
                {
                    validatableArgument.Throw();
                });
        }

        [TestMethod]
        public void ThrowException_WhenArgumentHasMatches()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = new ValidatableArgument<int>("validatableArgument", 3);
            validatableArgument.IsLessThan(5).IsGreaterThan(2);

            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    validatableArgument.Throw();
                }, "validatableArgument", "Invalid argument:\n - Argument value <3> is less than <5>.\r\n - Argument value <3> is greater than <2>.\r\n\r\nParameter name: validatableArgument");
        }
    }
}