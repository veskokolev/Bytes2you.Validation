using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.GuidArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotEmptyGuid_Should
    {
        [TestMethod]
        public void AddNotEmptyGuidValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<Guid> argument =
                new ValidatableArgument<Guid>("argument", Guid.NewGuid());

            // Act.
            argument.IsNotEmptyGuid();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GuidNotEmptyValidationPredicate));
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
                    argument.IsNotEmptyGuid();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}