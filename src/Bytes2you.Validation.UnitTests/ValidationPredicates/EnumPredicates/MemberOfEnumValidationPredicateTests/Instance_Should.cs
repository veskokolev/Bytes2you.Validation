using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumPredicates.MemberOfEnumValidationPredicateTests
{
    [TestClass]
    public class Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(MemberOfEnumValidationPredicate<CustomEnum>.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(MemberOfEnumValidationPredicate<CustomEnum>.Instance, MemberOfEnumValidationPredicate<CustomEnum>.Instance);
            }
        }
    }
}