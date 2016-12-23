namespace Extensions.Extensions
{
    public static class NullableExtensions
    {
        public static bool HasValueAndEquals<T>(this T? source, T target) where T : struct
        {
            return source.HasValue && source.Value.Equals(target);
        }

        public static bool HasValueAndEquals<T>(this T? source, T? target) where T : struct
        {
            return source.HasValue && source.Value.Equals(target);
        }
    }
}
