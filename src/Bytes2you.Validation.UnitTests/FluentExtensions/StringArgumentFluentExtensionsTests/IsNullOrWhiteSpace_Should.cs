using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.StringArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNullOrWhiteSpace_Should
    {
        [TestMethod]
        public void AddNullOrEmptyStringValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "string");

            // Act.
            argument.IsNullOrWhiteSpace();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(StringNullOrWhiteSpaceValidationPredicate));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", "string");

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNullOrWhiteSpace();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}