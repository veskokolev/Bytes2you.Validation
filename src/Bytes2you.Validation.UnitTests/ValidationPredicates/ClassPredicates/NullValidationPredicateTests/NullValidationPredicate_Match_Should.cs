using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ClassPredicates.NullValidationPredicateTests
{
    [TestClass]
    public class NullValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotNull()
        {
            // Arrange.
            object value = new object();

            // Act.
            IValidationPredicateResult result = NullValidationPredicate<object>.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("The argument is not null.", result.Message);
        }

        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsNull()
        {
            // Arrange.
            object value = null;

            // Act.
            IValidationPredicateResult result = NullValidationPredicate<object>.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is null.", result.Message);
        }
    }
}