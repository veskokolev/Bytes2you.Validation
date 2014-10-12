using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.LessThanOrEqualValidationRuleTests
{
    [TestClass]
    public class LessThanOrEqualValidationRule_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            LessThanOrEqualValidationRule<int> rule = new LessThanOrEqualValidationRule<int>(bound);

            // Assert.
            Assert.AreEqual(bound, rule.Bound);
        }
    }
}