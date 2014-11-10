using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinPredicates.SingletonValidationPredicateTests
{
    [TestClass]
    public class SingletonValidationPredicate_Constructors_Should
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowException_WhenTPredicateHasPublicConstructors()
        {
            SingletonValidationPredicateWithPublicConstructorMock singleton = SingletonValidationPredicateWithPublicConstructorMock.Instance;
        }
    }
}