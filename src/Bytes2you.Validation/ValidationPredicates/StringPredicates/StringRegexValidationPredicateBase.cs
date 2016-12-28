using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal abstract class StringRegexValidationPredicateBase : ValidationPredicate<string>
    {
        private readonly string pattern;

        public StringRegexValidationPredicateBase(string pattern)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException("pattern");
            }

            this.pattern = pattern;
        }

        public string Pattern
        {
            get
            {
                return this.pattern;
            }
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
        }
    }
}