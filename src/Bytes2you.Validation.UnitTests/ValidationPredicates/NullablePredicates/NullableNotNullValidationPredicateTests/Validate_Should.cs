using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.NullablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.NullablePredicates.NullableNotNullValidationPredicateTests
{
    [TestClass]
    public class Validate_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotNull()
        {
            // Arrange.
            int? value = 5;

            // Act.
            IValidationPredicateResult result = NullableNotNullValidationPredicate<int>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <5> is not null.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            int? value = null;

            // Act.
            IValidationPredicateResult result = NullableNotNullValidationPredicate<int>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null.", result.Message);
        }
    }
}