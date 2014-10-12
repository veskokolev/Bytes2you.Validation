using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.ValidationRuleTests
{
    [TestClass]
    public class ValidationRule_Validate_Should
    {
        [TestMethod]
        public void CallValidateOfT()
        {
            // Arrange.
            IntValidationRuleMock validationRule = new IntValidationRuleMock();
            object value = 3;

            // Act.
            ((IValidationRule)validationRule).Validate(value);

            // Assert.
            validationRule.AssertIsValidCalls(3);
        }
    }
}