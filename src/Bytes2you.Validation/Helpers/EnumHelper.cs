using System;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    internal static class EnumHelper
    {
        public static void ThrowIfNotEnum<TEnum>()
            where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException(
                    string.Format("The type <{0}> does not represent an enumeration.", typeof(TEnum).FullName), "TEnum");
            }
        }
    }
}