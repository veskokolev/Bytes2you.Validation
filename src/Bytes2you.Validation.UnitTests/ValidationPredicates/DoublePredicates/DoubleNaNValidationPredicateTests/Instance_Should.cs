using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoublePredicates.DoubleNaNValidationPredicateTests
{
    [TestClass]
    public class Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(DoubleNaNValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(DoubleNaNValidationPredicate.Instance, DoubleNaNValidationPredicate.Instance);
            }
        }
    }
}