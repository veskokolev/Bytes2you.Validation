using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.Helpers;
using Bytes2you.Validation.ValidationPredicates.EnumPredicates;

namespace Bytes2you.Validation
{
    // NOTE: C# 6.0 does not allow Enum constraints on Type parameters. 
    public static class EnumArgumentFluentExtensions
    {
        public static IValidatableArgument<TEnum> IsMemberOfEnum<TEnum>(this IArgument<TEnum> @argument)
            where TEnum : struct, IConvertible
        {
            EnumHelper.ThrowIfNotEnum<TEnum>();

            return @argument.AddValidationPredicate(MemberOfEnumValidationPredicate<TEnum>.Instance);
        }

        public static IValidatableArgument<TEnum> IsNotMemberOfEnum<TEnum>(this IArgument<TEnum> @argument)
            where TEnum : struct, IConvertible
        {
            EnumHelper.ThrowIfNotEnum<TEnum>();

            return @argument.AddValidationPredicate(NotMemberOfEnumValidationPredicate<TEnum>.Instance);
        }
    }
}