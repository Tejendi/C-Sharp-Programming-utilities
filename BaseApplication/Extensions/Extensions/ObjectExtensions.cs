using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Extensions.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Convert the object properties to a dictionary
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IDictionary<string, object> PropertiesToDictionary(this object source)
        {
            return source.PropertiesToDictionaryValueOfType<object>();
        }

        /// <summary>
        /// Converts the object properties to a dictionary the value type of the properties can be set with the type parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IDictionary<string, T> PropertiesToDictionaryValueOfType<T>(this object source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Unable to convert object to a dictionary. The source object is null.");
            }

            Dictionary<string, T> dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                AddPropertyToDictionary(property, source, dictionary);
            }

            return dictionary;
        }


        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, T> dictionary)
        {
            object value = property.GetValue(source);
            if (IsOfType<T>(value))
            {
                dictionary.Add(property.Name, (T)value);
            }
            else
            {
                T newValue = (T)Convert.ChangeType(value, typeof(T));
                dictionary.Add(property.Name, newValue);
            }
        }


        private static bool IsOfType<T>(this object value)
        {
            return value is T;
        }
    }
}
