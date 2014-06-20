using System;
using System.Linq;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation.UnitTests.Testing.Mocks
{
    internal class SingletonValidationRuleWithPublicConstructorMock : 
        SingletonValidationRule<SingletonValidationRuleWithPublicConstructorMock, int>
    {
        protected override bool IsValid(int value)
        {
            return true;
        }

        protected override string GetValidMessage(int value)
        {
            return "Valid message";
        }

        protected override string GetInvalidMessage(int value)
        {
            return "Invalid message";
        }
    }
}