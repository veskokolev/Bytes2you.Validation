using System;
using System.Linq;
using Bytes2you.Validation.UnitTests.Testing.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.ValidationRuleTests
{
    [TestClass]
    public class ValidationRule_Name_Should
    {
        [TestMethod]
        public void ReturnTheNameOfTheType()
        {
            // Arrange.
            IntValidationRuleMock validationRule = new IntValidationRuleMock();

            // Act.
            string name = validationRule.Name;

            // Assert.
            Assert.AreEqual(validationRule.GetType().Name, name);
        }
    }
}