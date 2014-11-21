using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ByteArgumentFluentExtensionsTests
{
    [TestClass]
    public class ByteArgumentFluentExtensions_IsEqual_Should
    {
        [TestMethod]
        public void AddEqualValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<byte> argument = new ValidatableArgument<byte>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is EqualValidationPredicate<byte>);
        }
    }
}