using System;

namespace Extensions.Extensions
{
    public static class StringExtensions
    {
        public static string TrimToLowerInvariant(this String str)
        {
            return str.Trim().ToLowerInvariant();
        }

        public static string TrimToUpperInvariant(this String str)
        {
            return str.Trim().ToUpperInvariant();
        }
    }
}
