using System;

namespace No._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 1, 3, 4, 7, 1, 1, 5, 6, 1, 8 };
            Console.WriteLine("Input: " + string.Join(" ", numbers));
            BubbleSort(numbers);
            Console.WriteLine("Output: " + string.Join(" ", numbers));
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
