using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.FloatArgumentFluentExtensionsTests
{
    [TestClass]
    public class FloatArgumentFluentExtensions_IsNotNegativeInfinity_Should
    {
        [TestMethod]
        public void AddNotEqualValidationPredicateWithFloatNegativeInfinityBound()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act.
            argument.IsNotNegativeInfinity();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            NotEqualValidationPredicate<float> validationPredicate = argument.ValidationPredicates.First() as NotEqualValidationPredicate<float>;
            Assert.IsNotNull(validationPredicate);
            Assert.AreEqual(validationPredicate.Bound, float.NegativeInfinity);
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
                    argument.IsNotNegativeInfinity();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}