using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.ClassPredicates;

namespace Bytes2you.Validation
{
    public static class ClassArgumentFluentExtensions
    {
        public static IValidatableArgument<T> IsNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationPredicate(NullValidationPredicate<T>.Instance);
        }

        public static IValidatableArgument<T> IsNotNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationPredicate(NotNullValidationPredicate<T>.Instance);
        }

        public static IValidatableArgument<T> IsInstanceOfType<T>(this IArgument<T> @argument, Type type)
            where T : class
        {
            return @argument.AddValidationPredicate(new InstanceOfTypeValidationPredicate<T>(type));
        }

        public static IValidatableArgument<T> IsNotInstanceOfType<T>(this IArgument<T> @argument, Type type)
            where T : class
        {
            return @argument.AddValidationPredicate(new NotInstanceOfTypeValidationPredicate<T>(type));
        }
    }
}