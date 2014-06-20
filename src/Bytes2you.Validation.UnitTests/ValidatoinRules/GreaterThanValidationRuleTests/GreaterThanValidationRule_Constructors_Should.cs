using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.GreaterThanValidationRuleTests
{
    [TestClass]
    public class GreaterThanValidationRule_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            GreaterThanValidationRule<int> rule = new GreaterThanValidationRule<int>(bound);

            // Assert.
            Assert.AreEqual(bound, rule.Bound);
        }
    }
}