using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.EnumPredicates
{
    internal class MemberOfEnumValidationPredicate<TEnum> : ValidationPredicate<TEnum>
        where TEnum : struct, IConvertible
    {
        private static readonly PortableLazy<MemberOfEnumValidationPredicate<TEnum>> lazyInstance;

        static MemberOfEnumValidationPredicate()
        {
            lazyInstance = new PortableLazy<MemberOfEnumValidationPredicate<TEnum>>(() => new MemberOfEnumValidationPredicate<TEnum>());
        }

        private MemberOfEnumValidationPredicate()
        {
        }

        public static MemberOfEnumValidationPredicate<TEnum> Instance
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
                ValidationPredicateMessages.MemberOfEnumMessage,
                value,
                value.GetType().FullName);
        }

        protected override string GetUnmatchMessage(TEnum value)
        {
            return MessageFormatHelper.Format(
                ValidationPredicateMessages.NotMemberOfEnumMessage,
                value,
                value.GetType().FullName);
        }

        protected override bool IsMatch(TEnum value)
        {
            return Enum.IsDefined(typeof(TEnum), value);
        }
    }
}