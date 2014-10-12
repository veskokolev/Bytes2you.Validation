using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    public abstract class BoundedArgumentValidationRule<T> : ValidationRule<T>
    {
        private readonly T bound;

        public BoundedArgumentValidationRule(T bound)
        {
            this.bound = bound;
        }

        public T Bound
        {
            get
            {
                return this.bound;
            }
        }

        protected override bool IsValid(T value)
        {
            return this.IsValid(bound, value);
        }

        protected abstract bool IsValid(T bound, T value);
    }
}