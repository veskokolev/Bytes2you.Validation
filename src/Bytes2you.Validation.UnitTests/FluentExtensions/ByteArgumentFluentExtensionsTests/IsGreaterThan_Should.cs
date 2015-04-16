using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ByteArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsGreaterThan_Should
    {
        [TestMethod]
        public void AddGreaterThanValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<byte> argument = new ValidatableArgument<byte>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<byte>));
        }
    }
}