using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.NullablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.NullablePredicates.NullableNullValidationPredicateTests
{
    [TestClass]
    public class NullableNullValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(NullableNullValidationPredicate<int>.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(NullableNullValidationPredicate<int>.Instance, NullableNullValidationPredicate<int>.Instance);
            }
        }
    }
}