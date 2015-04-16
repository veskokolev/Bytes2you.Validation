using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringNullOrWhiteSpaceValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            string value = null;

            // Act.
            IValidationPredicateResult result = StringNullOrWhiteSpaceValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is null, an empty string or contains only white space characters.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentConsistsOnlyOfWhiteSpaceCharacters()
        {
            // Arrange.
            string value = "   \t\r\n   ";

            // Act.
            IValidationPredicateResult result = StringNullOrWhiteSpaceValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is null, an empty string or contains only white space characters.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentConsistsOnlyOfNonWhiteSpaceChars()
        {
            // Arrange.
            string value = "asdf";

            // Act.
            IValidationPredicateResult result = StringNullOrWhiteSpaceValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <asdf> is neither null nor an empty string, nor contains only of white space characters.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentContainsNonWhiteSpaceChars()
        {
            // Arrange.
            string value = "     \r\nasdf";

            // Act.
            IValidationPredicateResult result = StringNullOrWhiteSpaceValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <     \r\nasdf> is neither null nor an empty string, nor contains only of white space characters.", result.Message);
        }
    }
}