using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.EnumerablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.EnumerablePredicates.EnumerableNotNullOrEmptyValidationPredicateTests
{
    [TestClass]
    public class EnumerableNotNullOrEmptyValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentHasElements()
        {
            // Arrange.
            int [] value = new int[] { 3, 4, 5 };

            // Act.
            IValidationPredicateResult result = EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument has elements.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            int[] value = null;

            // Act.
            IValidationPredicateResult result = EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            int[] value = new int[] {};

            // Act.
            IValidationPredicateResult result = EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}