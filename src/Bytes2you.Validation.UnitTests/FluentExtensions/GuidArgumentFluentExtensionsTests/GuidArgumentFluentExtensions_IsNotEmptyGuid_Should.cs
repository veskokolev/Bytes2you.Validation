using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.GuidArgumentFluentExtensionsTests
{
    [TestClass]
    public class GuidArgumentFluentExtensions_IsNotEmptyGuid_Should
    {
        [TestMethod]
        public void AddNotEmptyGuidValidationRule()
        {
            // Arrange.
            ValidatableArgument<Guid> argument =
                new ValidatableArgument<Guid>("argument", Guid.NewGuid());

            // Act.
            argument.IsNotEmptyGuid();

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is NotEmptyGuidValidationRule);
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            ValidatableArgument<Guid> argument =
                new ValidatableArgument<Guid>("argument", Guid.NewGuid());

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsNotEmptyGuid();
                },
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}