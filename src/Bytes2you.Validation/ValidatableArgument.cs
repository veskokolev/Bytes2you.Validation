using System;
using System.Collections.Generic;
using System.Linq;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    internal class ValidatableArgument<T> : IValidatableArgument<T>
    {
        private readonly string name;
        private readonly T value;
        private readonly List<IValidationRule<T>> validationRules;

        public ValidatableArgument(string name, T value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(ValidationRuleMessages.NullMessage, "name");
            }

            this.name = name;
            this.value = value;
            this.validationRules = new List<IValidationRule<T>>();
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

        public IEnumerable<IValidationRule<T>> ValidationRules
        {
            get
            {
                return this.validationRules;
            }
        }

        public void AddValidationRule(IValidationRule<T> validationRule)
        {
            if (validationRule == null)
            {
                throw new ArgumentException(ValidationRuleMessages.NullMessage, "validationRule");
            }

            this.validationRules.Add(validationRule);
        }
    }
}