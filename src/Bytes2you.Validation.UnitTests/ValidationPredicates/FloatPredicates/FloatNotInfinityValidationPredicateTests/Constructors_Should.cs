﻿using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.ValidationPredicates.FloatPredicates.FloatNotInfinityValidationPredicateTests
{
    [TestClass]
    public class Constructors_Should
    {
        [TestMethod]
        public void NotBePublic()
        {
            // Act.
            bool hasPublicConstructors = typeof(FloatNotInfinityValidationPredicate).HasPublicConstructors();

            // Assert.
            Assert.IsFalse(hasPublicConstructors);
        }
    }
}