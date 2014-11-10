using System;
using System.Collections.Generic;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidatableArgument<T> : IArgument<T>
    {
        IEnumerable<IValidationPredicate<T>> ValidationPredicates { get; }
        void AddValidationPredicate(IValidationPredicate<T> validationPredicate);
        IEnumerable<IValidationPredicateResult> MatchValidationPredicates();
    }
}