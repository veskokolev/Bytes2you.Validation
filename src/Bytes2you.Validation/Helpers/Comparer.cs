using System;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    internal static class Comparer
    {
        public static bool EqualsOfT<T>(T first, T second)
        {
            return (first == null && second == null) || (first != null && first.Equals(second));
        }
    }
}