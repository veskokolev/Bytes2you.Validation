using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.BoolPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.BoolArgumentFluentExtensionsTests
{
    [TestClass]
    public class BoolArgumentFluentExtensions_IsTrue_Should
    {
        [TestMethod]
        public void AddTrueValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<bool> argument = new ValidatableArgument<bool>("argument", true);

            // Act.
            argument.IsTrue();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is TrueValidationPredicate);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<bool> argument = new ValidatableArgument<bool>("argument", true);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsTrue();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}