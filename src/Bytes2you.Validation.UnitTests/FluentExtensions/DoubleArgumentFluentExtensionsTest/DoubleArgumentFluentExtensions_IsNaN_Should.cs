using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.DoubleArgumentFluentExtensionsTest
{
    [TestClass]
    public class DoubleArgumentFluentExtensions_IsNaN_Should
    {
        [TestMethod]
        public void AddDoubleNaNValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<double> argument =
                new ValidatableArgument<double>("argument", 5);

            // Act.
            argument.IsNaN();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is DoubleNaNValidationPredicate);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<double> argument =
                new ValidatableArgument<double>("argument", 5);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNaN();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}