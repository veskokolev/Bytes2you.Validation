using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationPredicateResult
    {
        bool IsMatch { get; }
        string Message { get; }
    }
}