using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class NotNullValidationPredicate<T> : ValidationPredicate<T>
        where T : class
    {
        private static readonly PortableLazy<NotNullValidationPredicate<T>> lazyInstance;

        static NotNullValidationPredicate()
        {
            lazyInstance = new PortableLazy<NotNullValidationPredicate<T>>(() => new NotNullValidationPredicate<T>());
        }

        private NotNullValidationPredicate()
        {
        }

        public static NotNullValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override bool IsMatch(T value)
        {
            return value != null;
        }
    }
}