using System;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class EqualValidationPredicate<T> : BoundedArgumentValidationPredicate<T>
    {
        public EqualValidationPredicate(T bound)
            : base(bound)
        {
        }

        protected override bool IsMatch(T bound, T value)
        {
            return Comparer.EqualsOfT(bound, value);
        }

        protected override string GetMatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.EqualMessage, this.Bound);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return string.Format(ValidationPredicateMessages.NotEqualMessage, value, this.Bound);
        }
    }
}