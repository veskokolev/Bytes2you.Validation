using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotNullNullableValidationPredicate<T> : SingletonValidationPredicate<NotNullNullableValidationPredicate<T>, Nullable<T>>
        where T : struct
    {
        private NotNullNullableValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Nullable<T> value)
        {
            return ValidationPredicateMessages.NotNullMessage;
        }

        protected override string GetUnmatchMessage(Nullable<T> value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override bool IsMatch(Nullable<T> value)
        {
            return value.HasValue;
        }
    }
}