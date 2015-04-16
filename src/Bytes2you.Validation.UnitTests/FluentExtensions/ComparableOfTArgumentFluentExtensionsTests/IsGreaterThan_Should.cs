using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ComparableOfTArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsGreaterThan_Should
    {
        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsInt()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<int>));
        }

        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsLong()
        {
            // Arrange.
            ValidatableArgument<long> argument = new ValidatableArgument<long>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<long>));
        }

        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsFloat()
        {
            // Arrange.
            ValidatableArgument<float> argument = new ValidatableArgument<float>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<float>));
        }

        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsDouble()
        {
            // Arrange.
            ValidatableArgument<double> argument = new ValidatableArgument<double>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<double>));
        }

        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsDecimal()
        {
            // Arrange.
            ValidatableArgument<decimal> argument = new ValidatableArgument<decimal>("argument", 3);

            // Act.
            argument.IsGreaterThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<decimal>));
        }

        [TestMethod]
        public void AddGreaterThanValidationPredicate_WhenArgumentIsDateTime()
        {
            // Arrange.
            ValidatableArgument<DateTime> argument = new ValidatableArgument<DateTime>("argument", DateTime.Now);

            // Act.
            argument.IsGreaterThan(DateTime.Now);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(GreaterThanValidationPredicate<DateTime>));
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
                    argument.IsGreaterThan(3);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}