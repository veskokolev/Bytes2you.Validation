using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.NullOrEmptyEnumerableValidationPredicateTests
{
    [TestClass]
    public class NullOrEmptyEnumerableValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentHasElements()
        {
            // Arrange.
            int[] value = new int[] { 3, 4, 5 };

            // Act.
            IValidationPredicateResult result = NullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument has elements.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            int[] value = null;

            // Act.
            IValidationPredicateResult result = NullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            int[] value = new int[] { };

            // Act.
            IValidationPredicateResult result = NullOrEmptyEnumerableValidationPredicate<int[]>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}