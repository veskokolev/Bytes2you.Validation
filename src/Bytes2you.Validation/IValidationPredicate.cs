using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidationPredicate
    {
        string Name { get; }
        ValidationType ValidationType { get; }
        IValidationPredicateResult Match(object value);
    }
}