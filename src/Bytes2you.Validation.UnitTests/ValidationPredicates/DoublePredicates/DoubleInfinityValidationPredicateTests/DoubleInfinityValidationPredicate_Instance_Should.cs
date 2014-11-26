using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.DoublePredicates.DoubleInfinityValidationPredicateTests
{
    [TestClass]
    public class DoubleInfinityValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(DoubleInfinityValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(DoubleInfinityValidationPredicate.Instance, DoubleInfinityValidationPredicate.Instance);
            }
        }
    }
}