using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.StringArgumentFluentExtensionsTests
{
    [TestClass]
    public class IsNotRegexMatch_Should
    {
        [TestMethod]
        public void AddStringNotRegexMatchValidationPredicate()
        {
            // Arrange.
            string value = TextHelper.GetTextWithLength(5000);
            ValidatableArgument<string> argument =
                new ValidatableArgument<string>("argument", value);

            // Act.
            argument.IsNotRegexMatch("xxx");

            // Assert.
            Assert.AreEqual(1, argument.ValidationPredicates.Count());
            Assert.IsInstanceOfType(argument.ValidationPredicates.First(), typeof(StringNotRegexMatchValidationPredicate));
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
                    argument.IsNotRegexMatch("abc");
                },
                PerformanceConstants.ValidationPredicateExecutionCount,
                PerformanceConstants.ValidationPredicateTotalExecutionExpectedTime);
        }
    }
}