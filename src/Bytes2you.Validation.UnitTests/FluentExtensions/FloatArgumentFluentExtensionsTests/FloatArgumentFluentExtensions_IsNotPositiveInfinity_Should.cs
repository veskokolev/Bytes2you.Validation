using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.FloatArgumentFluentExtensionsTests
{
    [TestClass]
    public class FloatArgumentFluentExtensions_IsNotPositiveInfinity_Should
    {
        [TestMethod]
        public void AddNotEqualValidationPredicateWithFloatPositiveInfinityBound()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act.
            argument.IsNotPositiveInfinity();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            NotEqualValidationPredicate<float> validationPredicate = argument.ValidationPredicates.First() as NotEqualValidationPredicate<float>;
            Assert.IsNotNull(validationPredicate);
            Assert.AreEqual(validationPredicate.Bound, float.PositiveInfinity);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

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