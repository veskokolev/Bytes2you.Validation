using System;
using System.Linq;
using System.Text.RegularExpressions;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNotRegexMatchValidationPredicate : StringRegexValidationPredicateBase
    {
        public StringNotRegexMatchValidationPredicate(string pattern)
            : base(pattern)
        {
        }

        protected override string GetMatchMessage(string value)
        {
            return MessageFormatHelper.Format(
                ValidationPredicateMessages.NotRegexMatchStringMessage,
                value,
                this.Pattern);
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(
                ValidationPredicateMessages.RegexMatchStringMessage,
                value,
                this.Pattern);
        }

        protected override bool IsMatch(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", ValidationPredicateMessages.NullMessage);
            }

            return !Regex.IsMatch(value, this.Pattern);
        }
    }
}