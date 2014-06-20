using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NullOrEmptyEnumerableValidationRuleTests
{
    [TestClass]
    public class NullOrEmptyEnumerableValidationRule_Constructors_Should
    {
        [TestMethod]
        public void NotBePublic()
        {
            // Act.
            bool hasPublicConstructors = typeof(NullOrEmptyEnumerableValidationRule).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructors);
        }
    }
}