using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Testing.Mocks
{
    internal class IntValidationPredicateMock : ValidationPredicate<int>
    {
        private readonly List<int> isMatchCalls;

        public IntValidationPredicateMock()
        {
            this.isMatchCalls = new List<int>();
        }

        public void AssertIsMatchCalls(params int[] expectedValues)
        {
            bool areEqual = Enumerable.SequenceEqual(expectedValues, this.isMatchCalls);
            Assert.IsTrue(areEqual);
        }

        protected override bool IsMatch(int value)
        {
            this.isMatchCalls.Add(value);
            
            return true;
        }

        protected override string GetMatchMessage(int value)
        {
            return "Match messasge";
        }

        protected override string GetUnmatchMessage(int value)
        {
            return "Unmatch message";
        }
    }
}