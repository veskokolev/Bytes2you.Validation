using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationPredicate<T> : IValidationPredicate
    {
        IValidationPredicateResult Match(T value);
    }
}