using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NullNullableValidationPredicate<T> : SingletonValidationPredicate<NullNullableValidationPredicate<T>, Nullable<T>>
        where T : struct
    {
        private NullNullableValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Nullable<T> value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override string GetUnmatchMessage(Nullable<T> value)
        {
            return ValidationPredicateMessages.NotNullMessage;
        }

        protected override bool IsMatch(Nullable<T> value)
        {
            return !value.HasValue;
        }
    }
}