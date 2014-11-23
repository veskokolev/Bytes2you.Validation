using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GenericPredicates.NotEqualValidationPredicateTests
{
    [TestClass]
    public class NotEqualValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            NotEqualValidationPredicate<int> validationPredicate = new NotEqualValidationPredicate<int>(bound);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
        }
    }
}