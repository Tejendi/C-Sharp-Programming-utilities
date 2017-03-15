using System;

namespace Extensions.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Validate if date is today
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsToday(this DateTime date)
        {
            if (date == null)
            {
                throw new ArgumentNullException(nameof(date));
            }

            return date.Date == DateTime.Now.Date;
        }

        /// <summary>
        /// Validate supplied dt is between startDate and endDate
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime dt, DateTime startDate, DateTime endDate)
        {
            return dt.Ticks >= startDate.Ticks && dt.Ticks <= endDate.Ticks;
        }
    }
}