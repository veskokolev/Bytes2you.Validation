using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Bytes2you.Validation
{
    public interface IValidatableArgument<T> : IArgument<T>
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        IEnumerable<IValidationPredicate<T>> ValidationPredicates { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        void AddValidationPredicate(IValidationPredicate<T> validationPredicate);

        [EditorBrowsable(EditorBrowsableState.Never)]
        IEnumerable<IValidationPredicateResult> MatchValidationPredicates();
    }
}