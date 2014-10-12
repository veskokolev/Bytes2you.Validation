using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationRule<T> : IValidationRule
    {
        IValidationResult Validate(T value);
    }
}