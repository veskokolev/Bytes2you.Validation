using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ArgumentOfTFluentExtensionsTests
{
    [TestClass]
    public class ArgumentOfTFluentExtensions_IsNotEqual_Should
    {
        [TestMethod]
        public void AddNotEqualValidationRule()
        {
            // Arrange.
            ValidatableArgument<int> argument = new ValidatableArgument<int>("argument", 3);

            // Act.
            argument.IsNotEqual(5);

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is NotEqualValidationRule<int>);
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
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}
