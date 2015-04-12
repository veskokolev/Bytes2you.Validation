using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringEqualValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            string bound = "abc";
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            // Act.
            StringEqualValidationPredicate validationPredicate = new StringEqualValidationPredicate(bound, comparisonType);

            // Assert.
            Assert.AreEqual(bound, validationPredicate.Bound);
            Assert.AreEqual(comparisonType, validationPredicate.ComparisonType);
        }
    }
}