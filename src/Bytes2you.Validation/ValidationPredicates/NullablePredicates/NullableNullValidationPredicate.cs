using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.NullablePredicates
{
    internal class NullableNullValidationPredicate<T> : ValidationPredicate<Nullable<T>>
        where T : struct
    {
        private static readonly PortableLazy<NullableNullValidationPredicate<T>> lazyInstance;

        static NullableNullValidationPredicate()
        {
            lazyInstance = new PortableLazy<NullableNullValidationPredicate<T>>(() => new NullableNullValidationPredicate<T>());
        }

        private NullableNullValidationPredicate()
        {
        }

        public static NullableNullValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
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