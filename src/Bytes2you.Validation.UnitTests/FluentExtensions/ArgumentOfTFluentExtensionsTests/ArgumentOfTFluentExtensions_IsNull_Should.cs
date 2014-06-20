﻿using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.FluentExtensions.ArgumentOfTFluentExtensionsTests
{
    [TestClass]
    public class ArgumentOfTFluentExtensions_IsNull_Should
    {
        [TestMethod]
        public void AddNullValidationRule()
        {
            // Arrange.
            ValidatableArgument<object> argument = new ValidatableArgument<object>("argument", new object());

            // Act.
            argument.IsNull();

            // Assert.
            Assert.AreEqual(1, argument.ValidationRules.Count());
            Assert.IsTrue(argument.ValidationRules.First() is NullValidationRule<object>);
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
                    argument.IsNull();
                },
                PerformanceConstants.RuleExecutionCount,
                PerformanceConstants.RuleTotalExecutionExpectedTime);
        }
    }
}