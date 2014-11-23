using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.GenericPredicates.EqualValidationPredicateTests
{
    [TestClass]
    public class EqualValidationPredicate_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            EqualValidationPredicate<int> validationPredicate = new EqualValidationPredicate<int>(bound);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
        }
    }
}