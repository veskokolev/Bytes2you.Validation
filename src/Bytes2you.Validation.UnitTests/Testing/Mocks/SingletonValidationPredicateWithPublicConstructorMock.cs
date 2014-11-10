using System;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation.UnitTests.Testing.Mocks
{
    internal class SingletonValidationPredicateWithPublicConstructorMock : 
        SingletonValidationPredicate<SingletonValidationPredicateWithPublicConstructorMock, int>
    {
        protected override bool IsMatch(int value)
        {
            return true;
        }

        protected override string GetMatchMessage(int value)
        {
            return "Match message";
        }

        protected override string GetUnmatchMessage(int value)
        {
            return "Unmatch message";
        }
    }
}