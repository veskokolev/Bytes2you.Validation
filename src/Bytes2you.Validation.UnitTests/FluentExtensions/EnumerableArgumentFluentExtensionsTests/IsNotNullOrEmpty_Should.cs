using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.EnumerablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.EnumerableArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotNullOrEmpty_Should
    {
        [TestMethod]
        public void AddEnumerableNotNullOrEmptyValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<int[]> argument =
                new ValidatableArgument<int[]>("argument", new int[] { 1, 2, 3 });

            // Act.
            argument.IsNotNullOrEmpty();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EnumerableNotNullOrEmptyValidationPredicate<int[]>));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<IEnumerable> argument =
                new ValidatableArgument<IEnumerable>("argument", new int[] { 1, 2, 3 });

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNotNullOrEmpty();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}