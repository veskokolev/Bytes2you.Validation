using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ComparablePredicates.LessThanOrEqualValidationPredicateTests
{
    [TestClass]
    public class LessThanOrEqualValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            LessThanOrEqualValidationPredicate<int> validationPredicate = new LessThanOrEqualValidationPredicate<int>(bound);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
        }
    }
}