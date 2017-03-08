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
        /// Validate supplied dt is between rangeBeg and rangeEnd
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="rangeBeg"></param>
        /// <param name="rangeEnd"></param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime dt, DateTime rangeBeg, DateTime rangeEnd)
        {
            return dt.Ticks >= rangeBeg.Ticks && dt.Ticks <= rangeEnd.Ticks;
        }
    }
}