namespace Interview.Core.Common.Helpers
{
    public static class Extensions
    {
        public static bool IsDivisibleBy(this int number, int divisor)
        {
            if (divisor == 0)
                return false;

            return number % divisor == 0;
        }
    }
}
