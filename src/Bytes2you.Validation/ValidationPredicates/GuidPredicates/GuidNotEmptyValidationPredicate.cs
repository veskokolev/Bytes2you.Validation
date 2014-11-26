using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.GuidPredicates
{
    internal class GuidNotEmptyValidationPredicate : ValidationPredicate<Guid>
    {
        private static readonly PortableLazy<GuidNotEmptyValidationPredicate> lazyInstance;

        static GuidNotEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<GuidNotEmptyValidationPredicate>(() => new GuidNotEmptyValidationPredicate());
        }

        private GuidNotEmptyValidationPredicate()
        {
        }

        public static GuidNotEmptyValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(Guid value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEmptyGuidMessage, value);
        }

        protected override string GetUnmatchMessage(Guid value)
        {
            return ValidationPredicateMessages.EmptyGuidMessage;
        }

        protected override bool IsMatch(Guid value)
        {
            return value != Guid.Empty;
        }
    }
}