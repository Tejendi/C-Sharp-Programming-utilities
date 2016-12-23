using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return list.Contains(source);
        }

        public static T FindMin<T, TValue>(this IEnumerable<T> list, Func<T, TValue> predicate) where TValue : IComparable<TValue>
        {
            T result = list.FirstOrDefault();
            if (result != null)
            {
                TValue bestMin = predicate(result);
                foreach (T item in list.Skip(1))
                {
                    TValue v = predicate(item);
                    if (v.CompareTo(bestMin) < 0)
                    {
                        bestMin = v;
                        result = item;
                    }
                }
            }
            return result;
        }

        public static T FindMax<T, TValue>(this IEnumerable<T> list, Func<T, TValue> predicate) where TValue : IComparable<TValue>
        {
            T result = list.FirstOrDefault();
            if (result != null)
            {
                TValue bestMax = predicate(result);
                foreach (T item in list.Skip(1))
                {
                    TValue v = predicate(item);
                    if (v.CompareTo(bestMax) > 0)
                    {
                        bestMax = v;
                        result = item;
                    }
                }
            }
            return result;
        }

   
    }
}