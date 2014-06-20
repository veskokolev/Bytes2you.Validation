using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Extensions.ArgumentExtensionsTests
{
    [TestClass]
    public class ArgumentExtensions_AddValidationRule_Should
    {
        [TestMethod]
        public void ThrowException_WhenArgumentIsNull()
        {
            // Arrange.
            IArgument<int> argument = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                argument.AddValidationRule(new EqualValidationRule<int>(3));
            }, "@argument");
        }

        [TestMethod]
        public void ThrowException_WhenValidationRuleArgumentIsNull()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                argument.AddValidationRule(null);
            }, "validationRule");
        }

        [TestMethod]
        public void AddTheGivenValidationRule_WhenValidationRuleArgumentIsNotNull()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("argument", 3);
            IValidationRule<int> validationRule1 = new LessThanValidationRule<int>(3);
            IValidationRule<int> validationRule2 = new GreaterThanValidationRule<int>(4);

            // Act.
            IValidatableArgument<int> validatableArgument = argument.AddValidationRule(validationRule1);
            validatableArgument.AddValidationRule(validationRule2);

            // Assert.
            Assert.AreEqual(2, validatableArgument.ValidationRules.Count());
            Assert.AreSame(validationRule1, validatableArgument.ValidationRules.First());
            Assert.AreSame(validationRule2, validatableArgument.ValidationRules.Last());
        }
    }
}