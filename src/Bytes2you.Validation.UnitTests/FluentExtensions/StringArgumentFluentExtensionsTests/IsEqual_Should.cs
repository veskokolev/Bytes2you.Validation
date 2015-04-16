using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.StringArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsEqual_Should
    {
        [TestMethod]
        public void AddNotNullOrEmptyStringValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "abc");

            // Act.
            argument.IsEqual("Abc", StringComparison.OrdinalIgnoreCase);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(StringEqualValidationPredicate));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "abc");

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsEqual("Abc", StringComparison.OrdinalIgnoreCase);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}