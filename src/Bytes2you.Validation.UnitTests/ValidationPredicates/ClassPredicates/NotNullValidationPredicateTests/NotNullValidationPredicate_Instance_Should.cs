using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.ClassPredicates.NotNullValidationPredicateTests
{
    [TestClass]
    public class NotNullValidationPredicate_Instance_Should
    {
        [TestMethod]
        public void ReturnNotNull()
        {
            // Assert.
            Assert.IsNotNull(NotNullValidationPredicate<object>.Instance);
        }

        [TestMethod]
        public void ReturnOneAndTheSameInstance()
        {
            // Assert.
            for (int i = 0; i < 5; i++)
            {
                Assert.AreSame(NotNullValidationPredicate<object>.Instance, NotNullValidationPredicate<object>.Instance);
            }
        }
    }
}