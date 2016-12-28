﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.FloatArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotNaN_Should
    {
        [TestMethod]
        public void AddFloatNotNaNValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<float> argument =
                new ValidatableArgument<float>("argument", 5);

            // Act.
            argument.IsNotNaN();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(FloatNotNaNValidationPredicate));
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
                    argument.IsNotNaN();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}