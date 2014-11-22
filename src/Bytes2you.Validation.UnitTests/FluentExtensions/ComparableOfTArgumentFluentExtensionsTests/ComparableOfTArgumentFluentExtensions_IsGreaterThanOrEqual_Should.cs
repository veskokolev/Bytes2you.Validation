using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ComparableOfTArgumentFluentExtensionsTests
{
    [TestClass]
    public class ComparableOfTArgumentFluentExtensions_IsGreaterThanOrEqual_Should
    {
        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsInt()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<int>);
        }

        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsLong()
        {
            // Arrange.
            ValidatableArgument<long> argument = new ValidatableArgument<long>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<long>);
        }

        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsFloat()
        {
            // Arrange.
            ValidatableArgument<float> argument = new ValidatableArgument<float>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<float>);
        }

        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsDouble()
        {
            // Arrange.
            ValidatableArgument<double> argument = new ValidatableArgument<double>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<double>);
        }

        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsDecimal()
        {
            // Arrange.
            ValidatableArgument<decimal> argument = new ValidatableArgument<decimal>("argument", 3);

            // Act.
            argument.IsGreaterThanOrEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<decimal>);
        }

        [TestMethod]
        public void AddGreaterThanOrEqualValidationPredicate_WhenArgumentIsDateTime()
        {
            // Arrange.
            ValidatableArgument<DateTime> argument = new ValidatableArgument<DateTime>("argument", DateTime.Now);

            // Act.
            argument.IsGreaterThanOrEqual(DateTime.Now);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is GreaterThanOrEqualValidationPredicate<DateTime>);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsGreaterThanOrEqual(3);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}