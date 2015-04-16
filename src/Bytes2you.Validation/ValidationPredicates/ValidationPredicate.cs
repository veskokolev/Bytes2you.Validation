using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    public abstract class ValidationPredicate<T> : IValidationPredicate<T>
    {
        private readonly string name;

        public ValidationPredicate()
        {
            this.name = this.GetType().Name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public abstract ValidationType ValidationType { get; }

        public IValidationPredicateResult Match(T value)
        {
            bool isMatch = this.IsMatch(value);
            string message;

            if (isMatch)
            {
                message = this.GetMatchMessage(value);
            }
            else
            {
                message = this.GetUnmatchMessage(value);
            }

            return new ValidationPredicateResult(isMatch, message, this.ValidationType);
        }

        protected abstract bool IsMatch(T value);
        protected abstract string GetMatchMessage(T value);
        protected abstract string GetUnmatchMessage(T value);

        IValidationPredicateResult IValidationPredicate.Match(object value)
        {
            return this.Match((T)value);
        }
    }
}