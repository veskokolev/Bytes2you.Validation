using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class LessThanValidationRule<T> : BoundedArgumentValidationRule<T>
        where T : IComparable<T>
    {
        public LessThanValidationRule(T bound)
            : base(bound)
        {
        }

        protected override string GetValidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.LessThanMessage, value, this.Bound);
        }

        protected override string GetInvalidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.GreaterThanOrEqualMessage, value, this.Bound);
        }

        protected override bool IsValid(T bound, T value)
        {
            return bound.CompareTo(value) > 0;
        }
    }
}