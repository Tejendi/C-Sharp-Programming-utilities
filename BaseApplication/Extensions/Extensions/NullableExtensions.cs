namespace Extensions.Extensions
{
    public static class NullableExtensions
    {
        /// <summary>
        /// Check if source has a value and if so if the value is equal to the target
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool HasValueAndEquals<T>(this T? source, T? target) where T : struct
        {
            return source.HasValue && source.Value.Equals(target);
        }
    }
}
