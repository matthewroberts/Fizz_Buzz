namespace Interview.Core.Common.Helpers
{
    public static class Extensions
    {
        public static bool IsDivisibleBy(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
