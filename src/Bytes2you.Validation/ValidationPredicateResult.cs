using Bytes2you.Validation.ValidationPredicates;
using System;
using System.Linq;

namespace Bytes2you.Validation
{
    internal class ValidationPredicateResult : IValidationPredicateResult
    {
        private readonly bool isMatch;
        private readonly string message;
        private readonly ValidationType validationType;

        public ValidationPredicateResult(bool isMatch, string message, ValidationType validationType)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            if (message == string.Empty)
            {
                throw new ArgumentException(ValidationPredicateMessages.NullOrEmptyStringMessage, "message");
            }

            this.isMatch = isMatch;
            this.message = message;
            this.validationType = validationType;
        }

        public bool IsMatch
        {
            get
            {
                return this.isMatch;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }

        public ValidationType ValidationType
        {
            get
            {
                return this.validationType;
            }
        }
    }
}