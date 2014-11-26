using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ClassArgumentFluentExtensions
{
    [TestClass]
    public class IsInstanceOfType_Should
    {
        [TestMethod]
        public void AddInstanceOfTypeValidationPredicate()
        {
            // Arrange.
            ValidatableArgument<object> argument = new ValidatableArgument<object>("argument", new object());

            // Act.
            argument.IsInstanceOfType(typeof(string));

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsTrue(argument.ValidationPredicates.First() is InstanceOfTypeValidationPredicate<object>);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<string> argument = new ValidatableArgument<string>("argument", "value");

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsInstanceOfType(typeof(string));
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}