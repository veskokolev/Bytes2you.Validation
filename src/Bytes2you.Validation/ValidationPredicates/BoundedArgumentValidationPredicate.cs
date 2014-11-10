using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    public abstract class BoundedArgumentValidationPredicate<T> : ValidationPredicate<T>
    {
        private readonly T bound;

        public BoundedArgumentValidationPredicate(T bound)
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

        protected override bool IsMatch(T value)
        {
            return this.IsMatch(bound, value);
        }

        protected abstract bool IsMatch(T bound, T value);
    }
}