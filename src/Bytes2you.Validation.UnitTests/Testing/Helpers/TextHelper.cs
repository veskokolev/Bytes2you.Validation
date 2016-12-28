using System;
using System.Linq;
using System.Text;

namespace Bytes2you.Validation.UnitTests.Testing.Helpers
{
    internal static class TextHelper
    {
        private static readonly string LoremIpsumText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public static string GetTextWithLength(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("Argument length must be greater than zero.");
            }

            StringBuilder result = new StringBuilder();

            while (result.Length < length)
            {
                result.Append(" " + LoremIpsumText);
            }

            return result.ToString().Substring(0, length);
        }
    }
}