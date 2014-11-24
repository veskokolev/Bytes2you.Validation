using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.DoubleArgumentFluentExtensionsTest
{
    [TestClass]
    public class DoubleArgumentFluentExtensions_IsNotPositiveInfinity_Should
    {
        [TestMethod]
        public void AddNotEqualValidationPredicateWithDoublePositiveInfinityBound()
        {
            // Arrange.
            ValidatableArgument<double> argument =
                new ValidatableArgument<double>("argument", 5);

            // Act.
            argument.IsNotPositiveInfinity();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            NotEqualValidationPredicate<double> validationPredicate = argument.ValidationPredicates.First() as NotEqualValidationPredicate<double>;
            Assert.IsNotNull(validationPredicate);
            Assert.AreEqual(validationPredicate.Bound, double.PositiveInfinity);
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
                    argument.IsNotPositiveInfinity();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}