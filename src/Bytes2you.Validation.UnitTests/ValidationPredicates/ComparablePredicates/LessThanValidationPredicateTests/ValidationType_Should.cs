using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ComparablePredicates.LessThanValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnRangeValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = new LessThanValidationPredicate<int>(3);

            // Assert.
            Assert.AreEqual(ValidationType.Range, validationPredicate.ValidationType);
        }
    }
}