using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.ValidationRules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bytes2you.Validation.UnitTests.Testing.Mocks
{
    internal class IntValidationRuleMock : ValidationRule<int>
    {
        private readonly List<int> isValidCalls;

        public IntValidationRuleMock()
        {
            this.isValidCalls = new List<int>();
        }

        public void AssertIsValidCalls(params int[] expectedValues)
        {
            bool areEqual = Enumerable.SequenceEqual(expectedValues, this.isValidCalls);
            Assert.IsTrue(areEqual);
        }

        protected override bool IsValid(int value)
        {
            this.isValidCalls.Add(value);
            
            return true;
        }

        protected override string GetValidMessage(int value)
        {
            return "ValidMessasge";
        }

        protected override string GetInvalidMessage(int value)
        {
            return "InvalidMessage";
        }
    }
}