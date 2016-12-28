using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.EnumPredicates
{
    internal class NotMemberOfEnumValidationPredicate<TEnum> : ValidationPredicate<TEnum>
        where TEnum : struct, IConvertible
    {
        private static readonly PortableLazy<NotMemberOfEnumValidationPredicate<TEnum>> lazyInstance;

        static NotMemberOfEnumValidationPredicate()
        {
            lazyInstance = new PortableLazy<NotMemberOfEnumValidationPredicate<TEnum>>(() => new NotMemberOfEnumValidationPredicate<TEnum>());
        }

        private NotMemberOfEnumValidationPredicate()
        {
        }

        public static NotMemberOfEnumValidationPredicate<TEnum> Instance
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

        protected override string GetMatchMessage(TEnum value)
        {
            return MessageFormatHelper.Format(
                ValidationPredicateMessages.NotMemberOfEnumMessage,
                value,
                value.GetType().FullName);
        }

        protected override string GetUnmatchMessage(TEnum value)
        {
            return MessageFormatHelper.Format(
                ValidationPredicateMessages.MemberOfEnumMessage,
                value,
                value.GetType().FullName);
        }

        protected override bool IsMatch(TEnum value)
        {
            return !Enum.IsDefined(typeof(TEnum), value);
        }
    }
}