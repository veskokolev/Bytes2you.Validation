using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    internal class ValidatableArgument<T> : IValidatableArgument<T>
    {
        private readonly string name;
        private readonly T value;
        private readonly List<IValidationPredicate<T>> validationPredicates;

        public ValidatableArgument(string name, T value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(ValidationPredicateMessages.NullMessage, "name");
            }

            this.name = name;
            this.value = value;
            this.validationPredicates = new List<IValidationPredicate<T>>();
        }

        public ValidatableArgument(IArgument<T> argument)
            : this(argument.Name, argument.Value)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public T Value
        {
            get
            {
                return this.value;
            }
        }

        public IEnumerable<IValidationPredicate<T>> ValidationPredicates
        {
            get
            {
                return this.validationPredicates;
            }
        }

        public void AddValidationPredicate(IValidationPredicate<T> validationPredicate)
        {
            if (validationPredicate == null)
            {
                throw new ArgumentException(ValidationPredicateMessages.NullMessage, "validationPredicate");
            }

            this.validationPredicates.Add(validationPredicate);
        }

        public IEnumerable<IValidationPredicateResult> MatchValidationPredicates()
        {
            List<IValidationPredicateResult> validationPredicateResults = new List<IValidationPredicateResult>();
            foreach (IValidationPredicate<T> validationPredicate in this.ValidationPredicates)
            {
                IValidationPredicateResult validationResult = validationPredicate.Match(this.Value);
                validationPredicateResults.Add(validationResult);
            }

            return validationPredicateResults;
        }
    }
}