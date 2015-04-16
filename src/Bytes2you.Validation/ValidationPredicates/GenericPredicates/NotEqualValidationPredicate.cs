using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.GenericPredicates
{
    internal class NotEqualValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
    {
        public NotEqualValidationPredicate(T bound)
            : base(bound)
        {
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEqualMessage, value, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.EqualMessage, this.Bound);
        }

        protected override bool IsMatch(T bound, T value)
        {
            return Comparer<T>.Default.Compare(bound, value) != 0;
        }
    }
}