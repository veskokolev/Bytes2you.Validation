using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.GenericArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotEqual_Should
    {
        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsInt()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<int>));
        }

        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsLong()
        {
            // Arrange.
            ValidatableArgument<long> argument = new ValidatableArgument<long>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<long>));
        }

        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsFloat()
        {
            // Arrange.
            ValidatableArgument<float> argument = new ValidatableArgument<float>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<float>));
        }

        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsDouble()
        {
            // Arrange.
            ValidatableArgument<double> argument = new ValidatableArgument<double>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<double>));
        }

        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsDecimal()
        {
            // Arrange.
            ValidatableArgument<decimal> argument = new ValidatableArgument<decimal>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<decimal>));
        }

        [TestMethod]
        public void AddNotEqualValidationPredicate_WhenArgumentIsDateTime()
        {
            // Arrange.
            ValidatableArgument<DateTime> argument = new ValidatableArgument<DateTime>("argument", DateTime.Now);

            // Act.
            argument.IsNotEqual(DateTime.Now);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(NotEqualValidationPredicate<DateTime>));
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
                    argument.IsNotEqual(3);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}
