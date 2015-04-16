using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.NotNullValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnDefaultValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = NotNullValidationPredicate<string>.Instance;

            // Assert.
            Assert.AreEqual(ValidationType.Default, validationPredicate.ValidationType);
        }
    }
}