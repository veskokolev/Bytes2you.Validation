using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ComparableOfTArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsLessThan_Should
    {
        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsInt()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<int>));
        }

        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsLong()
        {
            // Arrange.
            ValidatableArgument<long> argument = new ValidatableArgument<long>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<long>));
        }

        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsFloat()
        {
            // Arrange.
            ValidatableArgument<float> argument = new ValidatableArgument<float>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<float>));
        }

        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsDouble()
        {
            // Arrange.
            ValidatableArgument<double> argument = new ValidatableArgument<double>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<double>));
        }

        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsDecimal()
        {
            // Arrange.
            ValidatableArgument<decimal> argument = new ValidatableArgument<decimal>("argument", 3);

            // Act.
            argument.IsLessThan(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<decimal>));
        }

        [TestMethod]
        public void AddLessThanValidationPredicate_WhenArgumentIsDateTime()
        {
            // Arrange.
            ValidatableArgument<DateTime> argument = new ValidatableArgument<DateTime>("argument", DateTime.Now);

            // Act.
            argument.IsLessThan(DateTime.Now);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(LessThanValidationPredicate<DateTime>));
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
                    argument.IsLessThan(3);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}