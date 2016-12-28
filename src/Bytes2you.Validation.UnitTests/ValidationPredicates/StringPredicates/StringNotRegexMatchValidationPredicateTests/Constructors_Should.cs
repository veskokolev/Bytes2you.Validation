using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringNotRegexMatchValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void ThrowArgumentNullException_WhenPatternArgumentIsNull()
        {
            // Act & Assert.
            Ensure.ArgumentNullExceptionIsThrown(() =>
            {
                StringNotRegexMatchValidationPredicate validationPredicate = new StringNotRegexMatchValidationPredicate(null);
            }, "pattern");
        }


        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            string pattern = "abc";

            // Act.
            StringNotRegexMatchValidationPredicate validationPredicate = new StringNotRegexMatchValidationPredicate(pattern);

            // Assert.
            Assert.AreEqual(pattern, validationPredicate.Pattern);
        }
    }
}