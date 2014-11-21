using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.EqualValidationPredicateTests
{
    [TestClass]
    public class EqualValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsEqual()
        {
            // Arrange.
            EqualValidationPredicate<int> validationPredicate = new EqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(3);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is equal to 3.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotEqual()
        {
            // Arrange.
            EqualValidationPredicate<int> validationPredicate = new EqualValidationPredicate<int>(3);

            // Act.
            IValidationPredicateResult result = validationPredicate.Match(5);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value 5 is not equal to 3.", result.Message);
        }
    }
}