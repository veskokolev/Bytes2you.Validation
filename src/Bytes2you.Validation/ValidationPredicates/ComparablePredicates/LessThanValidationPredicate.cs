using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ComparablePredicates
{
    internal class LessThanValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
        where T : IComparable<T>
    {
        public LessThanValidationPredicate(T bound)
            : base(bound)
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.LessThanMessage, value, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.GreaterThanOrEqualMessage, value, this.Bound);
        }

        protected override bool IsMatch(T bound, T value)
        {
            return Comparer<T>.Default.Compare(bound, value) > 0;
        }
    }
}