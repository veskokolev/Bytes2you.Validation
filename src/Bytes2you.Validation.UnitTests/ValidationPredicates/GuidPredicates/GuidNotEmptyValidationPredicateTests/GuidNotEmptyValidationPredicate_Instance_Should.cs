using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.GuidPredicates.GuidNotEmptyValidationPredicateTests
{
    [TestClass]
    public class GuidNotEmptyValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(GuidNotEmptyValidationPredicate.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(GuidNotEmptyValidationPredicate.Instance, GuidNotEmptyValidationPredicate.Instance);
            }
        }
    }
}