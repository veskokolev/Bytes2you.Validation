using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.NullablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.NullablePredicates.NullableNotNullValidationPredicateTests
{
    [TestClass]
    public class NullableNotNullValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(NullableNotNullValidationPredicate<int>.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(NullableNotNullValidationPredicate<int>.Instance, NullableNotNullValidationPredicate<int>.Instance);
            }
        }
    }
}