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
        public void ThrowArgumentNullException_WhenValidatableArgumentIsNull()
        {
            // Arrange.
            IValidatableArgument<int> validatableArgument = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(
                () =>
                {
                    validatableArgument.Throw();
                }, "@validatableArgument");
        }

        [TestMethod]
        public void NotThrowAnyException_WhenArgumentHasNoMatches()
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
        public void ThrowArgumentNullException_WhenTheFirstMachingValidationRuleIsNull()
        {
            // Arrange.
            IValidatableArgument<string> argument = new ValidatableArgument<string>("argument", null);
            argument.IsEqual("asdf").IsNull();

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(
                () =>
                {
                    argument.Throw();
                }, "argument");
        }

        [TestMethod]
        public void ThrowArgumentException_WhenTheFirstMachingValidationRuleIsEqual()
        {
            // Arrange.
            IValidatableArgument<string> argument = new ValidatableArgument<string>("argument", "asdf");
            argument.IsNotEqual("asdf").IsEqual("asdf").IsNotNull();

            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    argument.Throw();
                }, "argument");
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeException_WhenTheFirstMatchingValidationRuleIsRangeRule()
        {
            // Arrange.
            IValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);
            argument.IsEqual(3).IsLessThan(10);

            // Act & Assert.
            Ensure.ArgumentOutOfRangeExceptionIsThrown(
                () =>
                {
                    argument.Throw();
                }, "argument");
        }
    }
}