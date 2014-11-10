using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.EmptyGuidValidationPredicateTests
{
    [TestClass]
    public class EmptyGuidValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndValidMessage_WhenArgumentIsGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.Empty;

            // Act.
            IValidationPredicateResult result = EmptyGuidValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Guid.Empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndInvalidMessage_WhenArgumentIsNotGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.NewGuid();

            // Act.
            IValidationPredicateResult result = EmptyGuidValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual(string.Format("Argument value '{0}' is not Guid.Empty.", value), result.Message);
        }
    }
}