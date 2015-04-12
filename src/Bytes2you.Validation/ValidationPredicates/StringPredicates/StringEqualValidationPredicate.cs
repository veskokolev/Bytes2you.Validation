using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringEqualValidationPredicate : BoundedArgumentValidationPredicate<string>
    {
        private readonly StringComparison comparisonType;

        public StringEqualValidationPredicate(string bound, StringComparison comparisonType)
            : base(bound)
        {
            this.comparisonType = comparisonType;
        }

        public StringComparison ComparisonType
        {
            get
            {
                return this.comparisonType;
            }
        }

        protected override bool IsMatch(string bound, string value)
        {
            return string.Compare(bound, value, this.comparisonType) == 0;
        }

        protected override string GetMatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.EqualStringMessage, value, this.Bound, this.ComparisonType);
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEqualStringMessage, value, this.Bound, this.ComparisonType);
        }
    }
}