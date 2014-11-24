using System;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    internal static class MessageFormatHelper
    {
        public static string Format(string format, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i] ?? "null";
            }

            return string.Format(format, args);
        }
    }
}