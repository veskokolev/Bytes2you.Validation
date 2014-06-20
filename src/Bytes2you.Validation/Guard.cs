using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Bytes2you.Validation
{
    public class Guard
    {
        [ExcludeFromCodeCoverage]
        private Guard()
        {
        }

        public static IArgument<T> WhenArgument<T>(T value, string name)
        {
            return new ValidatableArgument<T>(name, value);
        }
    }
}