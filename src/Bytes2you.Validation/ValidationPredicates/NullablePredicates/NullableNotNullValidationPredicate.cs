using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.NullablePredicates
{
    internal class NullableNotNullValidationPredicate<T> : ValidationPredicate<Nullable<T>>
        where T : struct
    {
        private static readonly PortableLazy<NullableNotNullValidationPredicate<T>> lazyInstance;

        static NullableNotNullValidationPredicate()
        {
            lazyInstance = new PortableLazy<NullableNotNullValidationPredicate<T>>(() => new NullableNotNullValidationPredicate<T>());
        }

        private NullableNotNullValidationPredicate()
        {
        }

        public static NullableNotNullValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
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