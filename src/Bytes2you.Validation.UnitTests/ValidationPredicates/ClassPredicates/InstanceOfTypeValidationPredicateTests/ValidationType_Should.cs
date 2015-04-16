using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.InstanceOfTypeValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnDefaultValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = new InstanceOfTypeValidationPredicate<string>(typeof(object));

            // Assert.
            Assert.AreEqual(ValidationType.Default, validationPredicate.ValidationType);
        }
    }
}