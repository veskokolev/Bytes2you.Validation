using System;
using System.Collections.Generic;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidatableArgument<T> : IArgument<T>
    {
        IEnumerable<IValidationRule<T>> ValidationRules { get; }
        void AddValidationRule(IValidationRule<T> validationRule);
    }
}