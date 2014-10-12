using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatableArgumentTests
{
    [TestClass]
    public class ValidatableArgument_AddValidationRule_Should
    {
        [TestMethod]
        public void ThrowException_WhenValidationRuleArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);
                    argument.AddValidationRule(null);
                }, "validationRule");
        }

        [TestMethod]
        public void AddValidationRuleToValidationRulesCollection_WhenValidationRuleArgumentIsNotNull()
        {
            // Arrange.
            IValidationRule<int> validationRule = new LessThanValidationRule<int>(5);
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);

            // Act.
            argument.AddValidationRule(validationRule);

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is LessThanValidationRule<int>);
        }
    }
}