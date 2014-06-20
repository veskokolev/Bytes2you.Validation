using System;
using System.Linq;
using System.Reflection;

namespace Bytes2you.Validation.Extensions
{
    internal static class TypeExtensions
    {
        public static bool HasPublicConstructors(this Type @type)
        {
            if (@type == null)
            {
                throw new ArgumentNullException("@type");
            }

            return @type.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Any();
        }
    }
}