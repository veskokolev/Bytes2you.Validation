using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.EnumerablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.EnumerableArgumentFluentExttensionsTests
{
    [TestClass]
    public class IsNullOrEmpty_Should
    {
        [TestMethod]
        public void AddNullOrEmptyEnumerableValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<int[]> argument =
                new ValidatableArgument<int[]>("argument", new int[] { 1, 2, 3 });

            // Act.
            argument.IsNullOrEmpty();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EnumerableNullOrEmptyValidationPredicate<int[]>));
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
                    argument.IsNullOrEmpty();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}