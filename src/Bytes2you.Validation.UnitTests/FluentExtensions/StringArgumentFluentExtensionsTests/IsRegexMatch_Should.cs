using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.StringArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsRegexMatch_Should
    {
        [TestMethod]
        public void AddStringRegexMatchValidationPredicate()
        {
            // Arrange.
            string value = TextHelper.GetTextWithLength(5000);
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", value);

            // Act.
            argument.IsRegexMatch("xxx");

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(StringRegexMatchValidationPredicate));
        }

        [TestMethod]
        public void RunInExpectedTime()
        {
            // Arrange.
            string value = TextHelper.GetTextWithLength(5000);
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", value);

            // Act & Assert.
            Ensure.ActionRunsInExpectedTime(
                () =>
                {
                    argument.IsRegexMatch("abc");
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}
