using System;
using System.Linq;

namespace Bytes2you.Validation
{
    internal class ValidationPredicateResult : IValidationPredicateResult
    {
        private readonly bool isMatch;
        private readonly string message;

        public ValidationPredicateResult(bool isMatch, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("The argument is null or empty.", "message");
            }

            this.isMatch = isMatch;
            this.message = message;
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
    }
}