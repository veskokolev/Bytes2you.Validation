using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    public abstract class ValidationRule<T> : IValidationRule<T>
    {
        private readonly string name;

        public ValidationRule()
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

        public IValidationResult Validate(T value)
        {
            bool isValid = this.IsValid(value);
            string message;

            if (isValid)
            {
                message = this.GetValidMessage(value);
            }
            else
            {
                message = this.GetInvalidMessage(value);
            }

            return new ValidationResult(isValid, message);
        }

        protected abstract bool IsValid(T value);
        protected abstract string GetValidMessage(T value);
        protected abstract string GetInvalidMessage(T value);

        IValidationResult IValidationRule.Validate(object value)
        {
            return this.Validate((T)value);
        }
    }
}