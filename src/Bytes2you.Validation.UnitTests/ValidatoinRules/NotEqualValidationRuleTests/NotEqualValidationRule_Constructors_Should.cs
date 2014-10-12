﻿using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidatoinRules.NotEqualValidationRuleTests
{
    [TestClass]
    public class NotEqualValidationRule_Constructors_Should
    {
        [TestMethod]
        public void SetTheGivenBoundToTheBoundProperty()
        {
            // Arrange.
            int bound = 3;

            // Act.
            NotEqualValidationRule<int> rule = new NotEqualValidationRule<int>(bound);

            // Assert.
            Assert.AreEqual(bound, rule.Bound);
        }
    }
}