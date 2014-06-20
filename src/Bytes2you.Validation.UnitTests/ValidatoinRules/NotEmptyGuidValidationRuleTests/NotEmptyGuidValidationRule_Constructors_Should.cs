using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NotEmptyGuidValidationRuleTests
{
    [TestClass]
    public class NotEmptyGuidValidationRule_Constructors_Should
    {
        [TestMethod]
        public void NotBePublic()
        {
            // Act.
            bool hasPublicConstructors = typeof(NotEmptyGuidValidationRule).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructors);
        }
    }
}