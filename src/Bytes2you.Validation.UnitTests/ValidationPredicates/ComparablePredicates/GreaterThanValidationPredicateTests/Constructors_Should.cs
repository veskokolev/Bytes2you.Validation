using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.GreaterThanValidationPredicateTests
{
    [TestClass]
    public class GreaterThanValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            GreaterThanValidationPredicate<int> validationPredicate = new GreaterThanValidationPredicate<int>(bound);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
        }
    }
}