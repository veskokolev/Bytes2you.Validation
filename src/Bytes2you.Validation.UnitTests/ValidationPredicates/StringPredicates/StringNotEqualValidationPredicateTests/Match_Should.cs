using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringNotEqualValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            string value = "xyz";
            StringNotEqualValidationPredicate validationPredicate = new StringNotEqualValidationPredicate("abc", StringComparison.OrdinalIgnoreCase);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <xyz> is not equal to <abc>. StringComparison <OrdinalIgnoreCase>.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsWithDifferentCaseAndComparisonTypeIsCaseSensitive()
        {
            // Arrange.
            string value = "Abc";
            StringNotEqualValidationPredicate validationPredicate = new StringNotEqualValidationPredicate("abc", StringComparison.Ordinal);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <Abc> is not equal to <abc>. StringComparison <Ordinal>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsWithDifferentCaseAndComparisonTypeIsCaseInsensitive()
        {
            // Arrange.
            string value = "Abc";
            StringNotEqualValidationPredicate validationPredicate = new StringNotEqualValidationPredicate("abc", StringComparison.OrdinalIgnoreCase);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <Abc> is equal to <abc>. StringComparison <OrdinalIgnoreCase>.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            string value = "abc";
            StringNotEqualValidationPredicate validationPredicate = new StringNotEqualValidationPredicate("abc", StringComparison.Ordinal);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value <abc> is equal to <abc>. StringComparison <Ordinal>.", result.Message);
        }
    }
}