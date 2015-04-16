using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.EnumerablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumerablePredicates.EnumerableNullOrEmptyValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnDefaultValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = EnumerableNullOrEmptyValidationPredicate<int[]>.Instance;

            // Assert.
            Assert.AreEqual(ValidationType.Default, validationPredicate.ValidationType);
        }
    }
}