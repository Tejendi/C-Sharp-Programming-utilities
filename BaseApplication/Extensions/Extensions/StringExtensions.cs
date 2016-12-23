using System;

namespace Extensions.Extensions
{
    public static class StringExtensions
    {
        public static string TrimToLowerInvariant(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Trim().ToLowerInvariant();
        }

        public static string TrimToUpperInvariant(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Trim().ToUpperInvariant();
        }

        public static string RemoveLastCharacter(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Substring(0, str.Length - 1);
        }

        public static string RemoveLast(this String str, int number)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Substring(0, str.Length - number);
        }

        public static string RemoveFirstCharacter(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Substring(1);
        }

        public static string RemoveFirst(this String str, int number)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            return str.Substring(number);
        }

        public static bool IsDate(this String str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                DateTime dt;
                return (DateTime.TryParse(str, out dt));
            }
            else
            {
                return false;
            }
        }

        public static string NullStringToEmptyString(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }


            return str;
        }
    }
}