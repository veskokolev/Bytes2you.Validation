using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.EnumerableArgumentFluentExttensionsTests
{
    [TestClass]
    public class EnumerableArgumentFluentExttensions_IsNullOrEmpty_Should
    {
        [TestMethod]
        public void AddNullOrEmptyEnumerableValidationRule()
        {
            // Arrange.
            ValidatableArgument<IEnumerable> argument =
                new ValidatableArgument<IEnumerable>("argument", new int[] { 1, 2, 3 });

            // Act.
            argument.IsNullOrEmpty();

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is NullOrEmptyEnumerableValidationRule);
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
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}