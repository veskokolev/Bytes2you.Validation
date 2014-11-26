using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.EnumerablePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.EnumerablePredicates.EnumerableNotNullOrEmptyValidationPredicateTests
{
    [TestClass]
    public class EnumerableNotNullOrEmptyValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance, EnumerableNotNullOrEmptyValidationPredicate<int[]>.Instance);
            }
        }
    }
}