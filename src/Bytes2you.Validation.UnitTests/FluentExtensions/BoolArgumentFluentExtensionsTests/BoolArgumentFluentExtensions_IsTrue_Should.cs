using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.BoolArgumentFluentExtensionsTests
{
    [TestClass]
    public class BoolArgumentFluentExtensions_IsTrue_Should
    {
        [TestMethod]
        public void AddTrueValidationRule()
        {
            // Arrange.
            ValidatableArgument<bool> argument = new ValidatableArgument<bool>("argument", true);

            // Act.
            argument.IsTrue();

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is TrueValidationRule);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<bool> argument = new ValidatableArgument<bool>("argument", true);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsTrue();
                },
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}