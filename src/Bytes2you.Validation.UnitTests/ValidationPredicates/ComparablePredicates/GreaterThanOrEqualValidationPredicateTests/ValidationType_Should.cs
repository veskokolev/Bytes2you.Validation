using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ComparablePredicates.GreaterThanOrEqualValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnRangeValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = new GreaterThanOrEqualValidationPredicate<int>(3);

            // Assert.
            Assert.AreEqual(ValidationType.Range, validationPredicate.ValidationType);
        }
    }
}