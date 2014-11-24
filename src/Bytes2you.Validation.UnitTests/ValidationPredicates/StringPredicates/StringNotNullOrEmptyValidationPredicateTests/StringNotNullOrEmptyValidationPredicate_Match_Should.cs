using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.StringPredicates.StringNotNullOrEmptyValidationPredicateTests
{
    [TestClass]
    public class StringNotNullOrEmptyValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentHasElements()
        {
            // Arrange.
            string value = "asdf";

            // Act.
            IValidationPredicateResult result = StringNotNullOrEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <{0}> is neither null nor empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            string value = null;

            // Act.
            IValidationPredicateResult result = StringNotNullOrEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            string value = string.Empty;

            // Act.
            IValidationPredicateResult result = StringNotNullOrEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null or empty.", result.Message);
        }
    }
}