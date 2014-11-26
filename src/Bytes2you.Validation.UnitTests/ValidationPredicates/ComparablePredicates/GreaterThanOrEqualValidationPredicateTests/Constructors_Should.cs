using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.GreaterThanOrEqualValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            GreaterThanOrEqualValidationPredicate<int> validationPredicate = new GreaterThanOrEqualValidationPredicate<int>(bound);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
        }
    }
}