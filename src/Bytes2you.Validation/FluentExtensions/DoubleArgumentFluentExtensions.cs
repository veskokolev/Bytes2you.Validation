using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;

namespace Bytes2you.Validation
{
    public static class DoubleArgumentFluentExtensions
    {
        public static IValidatableArgument<double> IsNaN(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNaNValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsNotNaN(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNotNaNValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsNotInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNotInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsPositiveInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoublePositiveInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsNotPositiveInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNotPositiveInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsNegativeInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNegativeInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<double> IsNotNegativeInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(DoubleNotNegativeInfinityValidationPredicate.Instance);
        }
    }
}