using System;

namespace No._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 4, 7, 8, 6, 9 };
            int k = 4; // jumlah komponen

            if (sequence.Length < k)
            {
                Console.WriteLine("Jumlah komponen tidak mencukupi untuk dijumlahkan.");
                return;
            }

            // Menghitung nilai minimal dan maksimal dari penjumlahan k komponen
            int minValue = FindMinSum(sequence, k);
            int maxValue = FindMaxSum(sequence, k);

            // Menampilkan hasil
            Console.WriteLine($"Nilai minimal penjumlahan {k} komponen: {minValue}");
            Console.WriteLine($"Nilai maksimal penjumlahan {k} komponen: {maxValue}");
        
        }

        static int FindMinSum(int[] sequence, int k)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i <= sequence.Length - k; i++)
            {
                int sum = 0;
                for (int j = i; j < i + k; j++)
                {
                    sum += sequence[j];
                }
                minValue = Math.Min(minValue, sum);
            }

            return minValue;
        }

        static int FindMaxSum(int[] sequence, int k)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i <= sequence.Length - k; i++)
            {
                int sum = 0;
                for (int j = i; j < i + k; j++)
                {
                    sum += sequence[j];
                }
                maxValue = Math.Max(maxValue, sum);
            }

            return maxValue;
        }
    }
}
