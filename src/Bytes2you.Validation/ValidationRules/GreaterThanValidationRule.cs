using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class GreaterThanValidationRule<T> : BoundedArgumentValidationRule<T>
        where T : IComparable<T>
    {
        public GreaterThanValidationRule(T bound)
            : base(bound)
        {
        }

        protected override string GetValidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.GreaterThanMessage, value, this.Bound);
        }

        protected override string GetInvalidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.LessThanOrEqualMessage, value, this.Bound);
        }

        protected override bool IsValid(T bound, T value)
        {
            return bound.CompareTo(value) < 0;
        }
    }
}