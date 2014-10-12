using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.EqualValidationRuleTests
{
    [TestClass]
    public class EqualValidationRule_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            EqualValidationRule<int> rule = new EqualValidationRule<int>(bound);

            // Assert.
            Assert.AreEqual(bound, rule.Bound);
        }
    }
}