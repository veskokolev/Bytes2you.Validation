using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bytes2you.Validation.UnitTests.Testing.Helpers;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringNotRegexMatchValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentContainsMatch()
        {
            // Arrange.
            IValidationPredicate<string> validationPredicate = new StringNotRegexMatchValidationPredicate("abc");
            string value = "xxxabcxxx";

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <xxxabcxxx> contains a match of the regular expression <abc>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentDoesNotContainMatch()
        {
            // Arrange.
            IValidationPredicate<string> validationPredicate = new StringNotRegexMatchValidationPredicate("abc");
            string value = "xxxxxx";

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <xxxxxx> does not contain a match of the regular expression <abc>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEmpty()
        {
            // Arrange.
            IValidationPredicate<string> validationPredicate = new StringNotRegexMatchValidationPredicate("abc");
            string value = string.Empty;

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <> does not contain a match of the regular expression <abc>.", result.Message);
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenValueArgumentIsNull()
        {
            // Arrange.
            IValidationPredicate<string> validationPredicate = new StringNotRegexMatchValidationPredicate("abc");

            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                validationPredicate.Match(null);
            }, "value");
        }
    }
}