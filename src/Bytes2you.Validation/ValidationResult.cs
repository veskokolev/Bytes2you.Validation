using System;
using System.Linq;

namespace Bytes2you.Validation
{
    internal class ValidationResult : IValidationResult
    {
        private readonly bool isValid;
        private readonly string message;

        public ValidationResult(bool isValid, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("The argument is null or empty.", "message");
            }

            this.isValid = isValid;
            this.message = message;
        }

        public bool IsValid
        {
            get
            {
                return this.isValid;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}