using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotEqualValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
    {
        public NotEqualValidationPredicate(T bound)
            : base(bound)
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.NotEqualMessage, value, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.EqualMessage, this.Bound);
        }

        protected override bool IsMatch(T bound, T value)
        {
            return !Comparer.EqualsOfT(bound, value);
        }
    }
}