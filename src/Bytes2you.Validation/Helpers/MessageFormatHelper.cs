using System;
using System.Globalization;
using System.Linq;

namespace Bytes2you.Validation.Helpers
{
    public static class MessageFormatHelper
    {
        public static string Format(string format, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i] ?? "null";
            }

            return string.Format(CultureInfo.InvariantCulture, format, args);
        }
    }
}