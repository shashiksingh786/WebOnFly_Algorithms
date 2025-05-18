namespace WebOnFly_Algorithms
{
    static internal class SumOfDigit
    {
        /// <summary>
        /// Sum of digit of a number
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Sum of digit</returns>
        public static int SumOfDigitOfNumber(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }

        /// <summary>
        /// Sum of digit of a number using Linq
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitOfNumberLinq(int n)
        {
            return n.ToString().Sum(c => c - '0');
        }

        /// <summary>
        /// Sum of digit of a number using recursion
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitOfNumberRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n % 10 + SumOfDigitOfNumberRecursion(n / 10);
        }

        /// <summary>
        /// Sum of digit of a number using Linq
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SumOfDigitOfNumberRecursionLinq(int n)
        {
            return n == 0 ? 0 : n % 10 + SumOfDigitOfNumberRecursionLinq(n / 10);
        }
    }
}