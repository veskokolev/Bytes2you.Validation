using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Helpers;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.StringPredicates.StringRegexMatchValidationPredicateTests
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
                StringRegexMatchValidationPredicate validationPredicate = new StringRegexMatchValidationPredicate(null);
            }, "pattern");
        }


        [TestMethod]
        public void SetAllGivenProperties()
        {
            // Arrange.
            string pattern = "abc";

            // Act.
            StringRegexMatchValidationPredicate validationPredicate = new StringRegexMatchValidationPredicate(pattern);

            // Assert.
            Assert.AreEqual(pattern, validationPredicate.Pattern);
        }
    }
}