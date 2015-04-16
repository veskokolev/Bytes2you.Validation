using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.GenericArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsEqual_Should
    {
        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsInt()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<int>));
        }

        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsLong()
        {
            // Arrange.
            ValidatableArgument<long> argument = new ValidatableArgument<long>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<long>));
        }

        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsFloat()
        {
            // Arrange.
            ValidatableArgument<float> argument = new ValidatableArgument<float>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<float>));
        }

        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsDouble()
        {
            // Arrange.
            ValidatableArgument<double> argument = new ValidatableArgument<double>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<double>));
        }

        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsDecimal()
        {
            // Arrange.
            ValidatableArgument<decimal> argument = new ValidatableArgument<decimal>("argument", 3);

            // Act.
            argument.IsEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<decimal>));
        }

        [TestMethod]
        public void AddEqualValidationPredicate_WhenArgumentIsDateTime()
        {
            // Arrange.
            ValidatableArgument<DateTime> argument = new ValidatableArgument<DateTime>("argument", DateTime.Now);

            // Act.
            argument.IsEqual(DateTime.Now);

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(EqualValidationPredicate<DateTime>));
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
                    argument.IsEqual(3);
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}