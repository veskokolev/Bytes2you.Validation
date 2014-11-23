using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GuidPredicates.GuidEmptyValidationPredicateTests
{
    [TestClass]
    public class GuidEmptyValidationPredicate_Match_Should
    {
        [TestMethod]
        public void ReturnTrueAndMatchMessage_WhenArgumentIsGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.Empty;

            // Act.
            IValidationPredicateResult result = GuidEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsTrue(result.IsMatch);
            Assert.AreEqual("The argument is Guid.Empty.", result.Message);
        }

        [TestMethod]
        public void ReturnFalseAndUnmatchMessage_WhenArgumentIsNotGuidEmpty()
        {
            // Arrange.
            Guid value = Guid.Parse("ed76438e-58f6-4d26-9067-9839c7c10b22");

            // Act.
            IValidationPredicateResult result = GuidEmptyValidationPredicate.Instance.Match(value);

            // Assert.
            Assert.IsFalse(result.IsMatch);
            Assert.AreEqual("Argument value ed76438e-58f6-4d26-9067-9839c7c10b22 is not Guid.Empty.", result.Message);
        }
    }
}