using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationRule
    {
        string Name { get; }
        IValidationResult Validate(object value);
    }
}