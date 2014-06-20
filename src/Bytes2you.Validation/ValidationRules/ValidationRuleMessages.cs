﻿using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal static class ValidationRuleMessages
    {
        public static readonly string LessThanMessage = "Argument value {0} is less than {1}.";
        public static readonly string GreaterThanMessage = "Argument value {0} is greater than {1}.";
        public static readonly string LessThanOrEqualMessage = "Argument value {0} is less than or equal to {1}.";
        public static readonly string GreaterThanOrEqualMessage = "Argument value {0} is greater than or equal to {1}.";

        public static readonly string EqualMessage = "The argument is equal to {0}.";
        public static readonly string NotEqualMessage = "Argument value {0} is not equal to {1}.";

        public static readonly string NullMessage  = "The argument is null.";
        public static readonly string NotNullMessage = "The argument is not null.";

        public static readonly string NullOrEmptyEnumerableMessage = "The argument is null or empty.";
        public static readonly string NotNullOrEmptyEnumerableMessage = "The argument has elements.";

        public static readonly string NullOrEmptyStringMessage = "The argument is null or empty.";
        public static readonly string NotNullOrEmptyStringMessage = "The argument is neither null nor empty.";

        public static readonly string TrueMessage = "The argument is true.";
        public static readonly string FalseMessage = "The argument is false.";

        public static readonly string EmptyGuidMessage = "The argument is Guid.Empty.";
        public static readonly string NotEmptyGuidMessage = "Argument value '{0}' is not Guid.Empty.";
    }
}