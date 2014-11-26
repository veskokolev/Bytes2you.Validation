using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ByteArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsGreaterThanOrEqual_Should
    {
        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<byte> argument = new ValidatableArgument<byte>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<byte>);
        }
    }
}