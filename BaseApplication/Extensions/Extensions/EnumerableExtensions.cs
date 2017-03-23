using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Check if object is in collection of objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool In<T>(this T source, IEnumerable<T> list)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return list.Contains(source);
        }

        /// <summary>
        /// Find object in collection where property is of lowest value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="list"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static T FindMin<T, TValue>(this IEnumerable<T> list, Func<T, TValue> predicate) where TValue : IComparable<TValue>
        {
            T result = list.FirstOrDefault();

            if (result == null)
                return result;

            TValue bestMin = predicate(result);

            foreach (T item in list.Skip(1))
            {
                TValue v = predicate(item);

                if (v.CompareTo(bestMin) >= 0)
                    continue;

                bestMin = v;
                result = item;
            }

            return result;
        }

        /// <summary>
        /// Find object in collection where property is of heighest value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="list"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static T FindMax<T, TValue>(this IEnumerable<T> list, Func<T, TValue> predicate) where TValue : IComparable<TValue>
        {
            T result = list.FirstOrDefault();

            if (result == null)
                return result;

            TValue bestMax = predicate(result);

            foreach (T item in list.Skip(1))
            {
                TValue v = predicate(item);

                if (v.CompareTo(bestMax) <= 0)
                    continue;

                bestMax = v;
                result = item;
            }

            return result;
        }
    }
}