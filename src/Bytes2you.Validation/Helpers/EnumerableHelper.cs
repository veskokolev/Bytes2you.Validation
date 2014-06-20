using System;
using System.Collections;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    internal static class EnumerableHelper
    {
        public static bool IsNullOrEmpty(IEnumerable enumerable)
        {
            return enumerable == null || !enumerable.GetEnumerator().MoveNext();
        }
    }
}