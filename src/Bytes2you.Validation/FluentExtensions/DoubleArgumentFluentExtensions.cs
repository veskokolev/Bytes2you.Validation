using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.DoublePredicates;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;

namespace Bytes2you.Validation
{
    public static class DoubleArgumentFluentExtensions
    {
        private static readonly EqualValidationPredicate<double> PositiveInfinityValidationPredicate;
        private static readonly NotEqualValidationPredicate<double> NotPositiveInfinityValidationPredicate;
        private static readonly EqualValidationPredicate<double> NegativeInfinityValidationPredicate;
        private static readonly NotEqualValidationPredicate<double> NotNegativeInfinityValidationPredicate;

        static DoubleArgumentFluentExtensions()
        {
            PositiveInfinityValidationPredicate = new EqualValidationPredicate<double>(double.PositiveInfinity);
            NotPositiveInfinityValidationPredicate = new NotEqualValidationPredicate<double>(double.PositiveInfinity);
            NegativeInfinityValidationPredicate = new EqualValidationPredicate<double>(double.NegativeInfinity);
            NotNegativeInfinityValidationPredicate = new NotEqualValidationPredicate<double>(double.NegativeInfinity);
        }

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
            return @argument.AddValidationPredicate(PositiveInfinityValidationPredicate);
        }

        public static IValidatableArgument<double> IsNotPositiveInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(NotPositiveInfinityValidationPredicate);
        }

        public static IValidatableArgument<double> IsNegativeInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(NegativeInfinityValidationPredicate);
        }

        public static IValidatableArgument<double> IsNotNegativeInfinity(this IArgument<double> @argument)
        {
            return @argument.AddValidationPredicate(NotNegativeInfinityValidationPredicate);
        }
    }
}