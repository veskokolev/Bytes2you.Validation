using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.GuidArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsEmptyGuid_Should
    {
        [TestMethod]
        public void AddEmptyGuidValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<Guid> argument =
                new ValidatableArgument<Guid>("argument", Guid.NewGuid());

            // Act.
            argument.IsEmptyGuid();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GuidEmptyValidationPredicate));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<Guid> argument =
                new ValidatableArgument<Guid>("argument", Guid.NewGuid());

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsEmptyGuid();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}