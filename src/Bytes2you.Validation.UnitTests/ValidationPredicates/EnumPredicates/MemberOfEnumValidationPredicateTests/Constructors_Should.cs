using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumPredicates.MemberOfEnumValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void NotBePublic()
        {
            // Act.
            bool hasPublicConstructors = typeof(MemberOfEnumValidationPredicate<CustomEnum>).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructors);
        }
    }
}