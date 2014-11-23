using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ShortArgumentFluentExtensionsTests
{
    [TestClass]
    public class ShortArgumentFluentExtensions_IsNotEqual_Should
    {
        [TestMethod]
        public void AddNotEqualValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<short> argument = new ValidatableArgument<short>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is NotEqualValidationPredicate<short>);
        }
    }
}