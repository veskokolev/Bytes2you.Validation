using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ValidationPredicateTests
{
    [TestClass]
    public class Match_Should
    {
        [TestMethod]
        public void CallValidateOfT()
        {
            // Arrange.
            IntValidationPredicateMock validationPredicate = new IntValidationPredicateMock();
            object value = 3;

            // Act.
            ((IValidationPredicate)validationPredicate).Match(value);

            // Assert.
            validationPredicate.AssertIsMatchCalls(3);
        }
    }
}