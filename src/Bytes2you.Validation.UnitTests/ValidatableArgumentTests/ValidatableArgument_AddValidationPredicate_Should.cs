using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatableArgumentTests
{
    [TestClass]
    public class ValidatableArgument_AddValidationPredicate_Should
    {
        [TestMethod]
        public void ThrowException_WhenValidationPredicateArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentExceptionIsThrown(
                () =>
                {
                    ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);
                    argument.AddValidationPredicate(null);
                }, "validationPredicate");
        }

        [TestMethod]
        public void AddValidationPredicateToValidationPredicatesCollection_WhenValidationPredicateArgumentIsNotNull()
        {
            // Arrange.
            IValidationPredicate<int> validationPredicate = new LessThanValidationPredicate<int>(5);
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);

            // Act.
            argument.AddValidationPredicate(validationPredicate);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is LessThanValidationPredicate<int>);
        }
    }
}