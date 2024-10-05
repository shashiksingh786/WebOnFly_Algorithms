namespace WebOnFly_Algorithms
{
    static internal class LargestAndSecondLargestNo
    {

        /// <summary>
        /// 1. Write an algorithm which finds the position of largest and second largest element in an array A with n>1 elements. Give its Complexity
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void FindLargestAndSecondLargestNoInArray(int[] arr)
        {
             if(arr.Length == 0) { Console.WriteLine("Empty Array List");  return; }

            int first = arr[0];
            int second = arr[1];

            // l1 -> Largest No.   l2-Second Largest No.
            int l1 = first;
            int l2 = second;
            if (first < second)
            {
                l1 = second;
                l2 = first;
            }

            for (int k = 2; k < arr.Length; k++)
            {
                if (first < arr[k])
                {
                    second = first;
                    first = arr[k];

                    l2 = second;
                    l1 = first;
                }
                else if (second < arr[k])
                {
                    second = arr[k];
                    l2 = second;
                }
            }
            Console.WriteLine($"Largest No. is {l1} and Second Largest No. is {l2}");


            /// Note - Complexity is O(n)

        }


        /// <summary>
        /// 2. Use of Array - Write an algorithm which finds the position of largest and second largest element in an array A with n>1 elements. Give its Complexity
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void FindLargestAndSecondLargestNoInArrayNext(int[] arr)
        {
            if (arr.Length == 0) { Console.WriteLine("Empty Array List"); return; }

            Array.Sort(arr);
            Array.Reverse(arr);

            int first = arr[0];
            int second = arr[1];

            Console.WriteLine($"Largest No. is {first} and Second Largest No. is {second}");

        }
    }
}
