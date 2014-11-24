using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.NullablePredicates
{
    internal class NullableNotNullValidationPredicate<T> : SingletonValidationPredicate<NullableNotNullValidationPredicate<T>, Nullable<T>>
        where T : struct
    {
        private NullableNotNullValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Nullable<T> value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
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