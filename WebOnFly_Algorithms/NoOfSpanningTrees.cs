namespace WebOnFly_Algorithms
{
    static internal class NoOfSpanningTrees
    {
        public static long CalculateSpanningTrees(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return (long)Math.Pow(n, n - 2);
        }
    }
}