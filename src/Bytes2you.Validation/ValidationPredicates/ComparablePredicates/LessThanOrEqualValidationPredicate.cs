using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ComparablePredicates
{
    internal class LessThanOrEqualValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
        where T : IComparable<T>
    {
        public LessThanOrEqualValidationPredicate(T bound)
            : base(bound)
        {
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Range;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.LessThanOrEqualMessage, value, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.GreaterThanMessage, value, this.Bound);
        }

        protected override bool IsMatch(T bound, T value)
        {
            return Comparer<T>.Default.Compare(bound, value) >= 0;
        }
    }
}