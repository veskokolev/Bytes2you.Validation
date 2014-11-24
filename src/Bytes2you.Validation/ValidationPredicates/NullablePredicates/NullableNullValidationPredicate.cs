using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.NullablePredicates
{
    internal class NullableNullValidationPredicate<T> : SingletonValidationPredicate<NullableNullValidationPredicate<T>, Nullable<T>>
        where T : struct
    {
        private NullableNullValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Nullable<T> value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override string GetUnmatchMessage(Nullable<T> value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
        }

        protected override bool IsMatch(Nullable<T> value)
        {
            return !value.HasValue;
        }
    }
}