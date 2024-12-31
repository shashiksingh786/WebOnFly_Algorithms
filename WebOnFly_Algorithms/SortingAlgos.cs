namespace WebOnFly_Algorithms
{
    static internal class SortingAlgos
    {
        /// <summary>
        /// Bubble Sorting - its time complexity - O(n^2)
        /// </summary>
        /// <param name="arr">Array List</param>
        /// <param name="n">Length of Array</param>
        public static void BubbleSort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                bool isSwap = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]); // for swap element in array using tuple
                        isSwap = true;
                    }
                }
                if (!isSwap)
                {
                    return;
                }
            }           
        }

        /// <summary>
        /// Print list of array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public static void PrintArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] +" ");
            }
        }
    }

}