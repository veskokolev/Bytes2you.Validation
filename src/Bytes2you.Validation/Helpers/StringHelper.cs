using System;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    internal static class StringHelper
    {
        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null)
            {
                return true;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsEmpty(string value)
        {
            return value != null && value.Length == 0;
        }
    }
}