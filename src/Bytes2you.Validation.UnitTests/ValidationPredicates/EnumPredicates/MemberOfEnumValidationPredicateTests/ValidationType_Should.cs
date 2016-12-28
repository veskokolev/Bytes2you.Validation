using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumPredicates.MemberOfEnumValidationPredicateTests
{
    [TestClass]
    public class ValidationType_Should
    {
        [TestMethod]
        public void ReturnDefaultValidationType()
        {
            // Arrange.
            IValidationPredicate validationPredicate = MemberOfEnumValidationPredicate<CustomEnum>.Instance;

            // Assert.
            Assert.AreEqual(ValidationType.Default, validationPredicate.ValidationType);
        }
    }
}