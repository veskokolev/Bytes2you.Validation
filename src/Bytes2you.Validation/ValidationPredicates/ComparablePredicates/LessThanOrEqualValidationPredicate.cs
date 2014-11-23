using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.ComparablePredicates
{
    internal class LessThanOrEqualValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
        where T : IComparable<T>
    {
        public LessThanOrEqualValidationPredicate(T bound)
            : base(bound)
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.LessThanOrEqualMessage, value, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.GreaterThanMessage, value, this.Bound);
        }

        protected override bool IsMatch(T bound, T value)
        {
            return bound.CompareTo(value) >= 0;
        }
    }
}