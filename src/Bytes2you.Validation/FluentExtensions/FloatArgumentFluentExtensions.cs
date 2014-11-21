using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class FloatArgumentFluentExtensions
    {
        public static IValidatableArgument<float> IsNaN(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNaNValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsNotNaN(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNotNaNValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsNotInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNotInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsPositiveInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatPositiveInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsNotPositiveInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNotPositiveInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsNegativeInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNegativeInfinityValidationPredicate.Instance);
        }

        public static IValidatableArgument<float> IsNotNegativeInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(FloatNotNegativeInfinityValidationPredicate.Instance);
        }
    }
}