using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NullOrEmptyStringValidationRuleTests
{
    [TestClass]
    public class NullOrEmptyStringValidationRule_Constructors_Should
    {
        [TestMethod]
        public void NotBePublic()
        {
            // Act.
            bool hasPublicConstructors = typeof(NullOrEmptyStringValidationRule).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructors);
        }
    }
}