using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ClassPredicates.NotNullValidationPredicateTests
{
    [TestClass]
    public class NotNullValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNotNull()
        {
            // Arrange.
            object value = new object();

            // Act.
            IValidationPredicateResult result = NotNullValidationPredicate<object>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("Argument value <System.Object> is not null.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            object value = null;

            // Act.
            IValidationPredicateResult result = NotNullValidationPredicate<object>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is null.", result.Message);
        }
    }
}