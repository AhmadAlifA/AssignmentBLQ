using System;

namespace No._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 3, 9, 0, 7, 1, 2, 4 }, sequence1 = { 3, 9, 0, 7, 1, 2, 4 }; ;
            Console.WriteLine("Input: " + string.Join(" ", sequence));
            
            int n = 3;
            RotateLeft(sequence, n);
            Console.WriteLine("Output: " + string.Join(" ", sequence));

            n = 1;
            RotateLeft(sequence1, n);
            Console.WriteLine("Output: " + string.Join(" ", sequence1));
        }

        static void RotateLeft(int[] array, int n)
        {

            n = n % array.Length;

            for (int i = 0; i < n; i++)
            {
                int temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = temp;
            }
        }
    }
}
