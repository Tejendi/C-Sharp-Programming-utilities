using System;

namespace Extensions.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Trim and lowercase text
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TrimToLowerInvariant(this String str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Trim().ToLowerInvariant();
        }

        /// <summary>
        /// Trim and uppercase text
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TrimToUpperInvariant(this String str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Trim().ToUpperInvariant();
        }

        /// <summary>
        /// Remove last character of text
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(this String str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Substring(0, str.Length - 1);
        }

        /// <summary>
        /// Remove last characters from string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string RemoveLast(this String str, int number)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Substring(0, str.Length - number);
        }

        /// <summary>
        /// Remove first characters
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveFirstCharacter(this String str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Substring(1);
        }

        /// <summary>
        /// Remove first number of characters
        /// </summary>
        /// <param name="str"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string RemoveFirst(this String str, int number)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Substring(number);
        }

        /// <summary>
        /// Check if string is a recongnized date string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDate(this String str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            DateTime dt;
            return (DateTime.TryParse(str, out dt));
        }

        /// <summary>
        /// Make a string value of null equals and empty string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NullStringToEmptyString(this String str)
        {
            return string.IsNullOrWhiteSpace(str) ? string.Empty : str;
        }
    }
}