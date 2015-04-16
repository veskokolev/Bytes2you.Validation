using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringNotEmptyValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentHasElements()
        {
            // Arrange.
            string value = "asdf";

            // Act.
            IValidationPredicateResult result = StringNotEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <asdf> is not an empty string.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            string value = null;

            // Act.
            IValidationPredicateResult result = StringNotEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <null> is not an empty string.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            string value = string.Empty;

            // Act.
            IValidationPredicateResult result = StringNotEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is an empty string.", result.Message);
        }
    }
}