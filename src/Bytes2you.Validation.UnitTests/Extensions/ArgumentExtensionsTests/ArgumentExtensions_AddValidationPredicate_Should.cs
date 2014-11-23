using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Extensions.ArgumentExtensionsTests
{
    [TestClass]
    public class ArgumentExtensions_AddValidationPredicate_Should
    {
        [TestMethod]
        public void ThrowException_WhenArgumentIsNull()
        {
            // Arrange.
            IArgument<int> argument = null;

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                argument.AddValidationPredicate(new EqualValidationPredicate<int>(3));
            }, "@argument");
        }

        [TestMethod]
        public void ThrowException_WhenValidationPredicateArgumentIsNull()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                argument.AddValidationPredicate(null);
            }, "validationPredicate");
        }

        [TestMethod]
        public void AddTheGivenValidationPredicate_WhenValidationPredicateArgumentIsNotNull()
        {
            // Arrange.
            IArgument<int> argument = new ValidatableArgument<int>("argument", 3);
            IValidationPredicate<int> validationPredicate1 = new LessThanValidationPredicate<int>(3);
            IValidationPredicate<int> validationPredicate2 = new GreaterThanValidationPredicate<int>(4);

            // Act.
            IValidatableArgument<int> validatableArgument = argument.AddValidationPredicate(validationPredicate1);
            validatableArgument.AddValidationPredicate(validationPredicate2);

            // Assert.
            Assert.AreEqual(2, validatableArgument.ValidationPredicates.Count());
            Assert.AreSame(validationPredicate1, validatableArgument.ValidationPredicates.First());
            Assert.AreSame(validationPredicate2, validatableArgument.ValidationPredicates.Last());
        }
    }
}