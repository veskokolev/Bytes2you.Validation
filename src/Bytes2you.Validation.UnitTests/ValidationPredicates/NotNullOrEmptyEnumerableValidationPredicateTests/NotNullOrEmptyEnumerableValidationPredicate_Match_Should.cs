using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.NotNullOrEmptyEnumerableValidationPredicateTests
{
    [TestClass]
    public class NotNullOrEmptyEnumerableValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentHasElements()
        {
            // Arrange.
            int [] value = new int[] { 3, 4, 5 };

            // Act.
            IValidationPredicateResult result = NotNullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument has elements.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNull()
        {
            // Arrange.
            int[] value = null;

            // Act.
            IValidationPredicateResult result = NotNullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            int[] value = new int[] {};

            // Act.
            IValidationPredicateResult result = NotNullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}