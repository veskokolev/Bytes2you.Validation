using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.BoolPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.BoolsPredicates.FalseValidationPredicateTests
{
    [TestClass]
    public class FalseValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(FalseValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(FalseValidationPredicate.Instance, FalseValidationPredicate.Instance);
            }
        }
    }
}