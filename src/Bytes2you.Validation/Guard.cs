using System;
using System.Linq;

namespace Bytes2you.Validation
{
    public static class Guard
    {
        public static IArgument<T> WhenArgument<T>(T value, string name)
        {
            return new ValidatableArgument<T>(name, value);
        }
    }
}