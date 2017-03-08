using System.Collections.Generic;

namespace Extensions.Extensions
{
    public static class IntigerExtensions
    {
        /// <summary>
        /// Determines whether the specified value falls between start and end value. Check is done inclusive of start and end.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns>
        ///   <c>true</c> if the specified start is between; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBetween(this int value, int start, int end)
        {
            return Comparer<int>.Default.Compare(value, start) >= 0 && Comparer<int>.Default.Compare(value, end) <= 0;
        }

        /// <summary>
        /// Check if int is odd
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Check if int is even
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
    }
}