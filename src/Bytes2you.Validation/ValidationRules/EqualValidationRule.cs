using System;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationRules
{
    internal class EqualValidationRule<T> : BoundedArgumentValidationRule<T>
    {
        public EqualValidationRule(T bound)
            : base(bound)
        {
        }

        protected override bool IsValid(T bound, T value)
        {
            return Comparer.EqualsOfT(bound, value);
        }

        protected override string GetValidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.EqualMessage, this.Bound);
        }

        protected override string GetInvalidMessage(T value)
        {
            return string.Format(ValidationRuleMessages.NotEqualMessage, value, this.Bound);
        }
    }
}