using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationResult
    {
        bool IsValid { get; }
        string Message { get; }
    }
}