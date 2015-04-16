using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatableArgumentTests
{
    [TestClass]
    public class AddValidationPredicate_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenValidationPredicateArgumentIsNull()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 5);

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(
                () =>
                {
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
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<int>));
        }
    }
}