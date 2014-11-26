using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.ValidationPredicateTests
{
    [TestClass]
    public class Name_Should
    {
        [TestMethod]
        public void ReturnTheNameOfTheType()
        {
            // Arrange.
            IntValidationPredicateMock validationPredicate = new IntValidationPredicateMock();

            // Act.
            string name = validationPredicate.Name;

            // Assert.
            Assert.AreEqual(validationPredicate.GetType().Name, name);
        }
    }
}