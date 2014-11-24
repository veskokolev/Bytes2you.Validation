using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.FloatPredicates;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;

namespace Bytes2you.Validation
{
    public static class FloatArgumentFluentExtensions
    {
        private static readonly EqualValidationPredicate<float> PositiveInfinityValidationPredicate;
        private static readonly NotEqualValidationPredicate<float> NotPositiveInfinityValidationPredicate;
        private static readonly EqualValidationPredicate<float> NegativeInfinityValidationPredicate;
        private static readonly NotEqualValidationPredicate<float> NotNegativeInfinityValidationPredicate;

        static FloatArgumentFluentExtensions()
        {
            PositiveInfinityValidationPredicate = new EqualValidationPredicate<float>(float.PositiveInfinity);
            NotPositiveInfinityValidationPredicate = new NotEqualValidationPredicate<float>(float.PositiveInfinity);
            NegativeInfinityValidationPredicate = new EqualValidationPredicate<float>(float.NegativeInfinity);
            NotNegativeInfinityValidationPredicate = new NotEqualValidationPredicate<float>(float.NegativeInfinity);
        }

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
            return @argument.AddValidationPredicate(PositiveInfinityValidationPredicate);
        }

        public static IValidatableArgument<float> IsNotPositiveInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(NotPositiveInfinityValidationPredicate);
        }

        public static IValidatableArgument<float> IsNegativeInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(NegativeInfinityValidationPredicate);
        }

        public static IValidatableArgument<float> IsNotNegativeInfinity(this IArgument<float> @argument)
        {
            return @argument.AddValidationPredicate(NotNegativeInfinityValidationPredicate);
        }
    }
}