using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.LessThanValidationRuleTests
{
    [TestClass]
    public class LessThanValidationRule_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            LessThanValidationRule<int> rule = new LessThanValidationRule<int>(bound);

            // Assert.
            Assert.AreEqual(bound, rule.Bound);
        }
    }
}