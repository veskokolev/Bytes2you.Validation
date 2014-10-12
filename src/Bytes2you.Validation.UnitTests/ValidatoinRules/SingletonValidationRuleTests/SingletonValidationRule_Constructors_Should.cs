using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.SingletonValidationRuleTests
{
    [TestClass]
    public class SingletonValidationRule_Constructors_Should
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowException_WhenTRuleHasPublicConstructors()
        {
            SingletonValidationRuleWithPublicConstructorMock singleton = SingletonValidationRuleWithPublicConstructorMock.Instance;
        }
    }
}