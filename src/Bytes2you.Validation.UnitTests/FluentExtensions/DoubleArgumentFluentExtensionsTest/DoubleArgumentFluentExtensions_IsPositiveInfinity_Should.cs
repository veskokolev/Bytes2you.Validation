﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.DoubleArgumentFluentExtensionsTest
{
    [TestClass]
    public class DoubleArgumentFluentExtensions_IsPositiveInfinity_Should
    {
        [TestMethod]
        public void AddDoublePositiveInfinityValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<double> argument =
                new ValidatableArgument<double>("argument", 5);

            // Act.
            argument.IsPositiveInfinity();

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is DoublePositiveInfinityValidationPredicate);
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
                    argument.IsPositiveInfinity();
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}