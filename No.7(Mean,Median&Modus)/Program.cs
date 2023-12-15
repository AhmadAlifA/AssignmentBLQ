using System;
using System.Linq;

namespace No._7_Mean_Median_Modus_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 7, 0, 2, 7, 1, 7, 6, 3, 0, 7, 1, 3, 4, 6, 1, 6, 4, 3 };

            // Mean
            double mean = numbers.Sum() / (double)numbers.Length;

            // Median
            int[] sortedNumbers = numbers.OrderBy(n => n).ToArray();
            int middleIndex = sortedNumbers.Length / 2;
            double median = (sortedNumbers.Length % 2 == 0)
                ? (sortedNumbers[middleIndex - 1] + sortedNumbers[middleIndex]) / 2.0
                : sortedNumbers[middleIndex];

            // Modus
            var groupedNumbers = numbers.GroupBy(n => n);
            var maxFrequency = groupedNumbers.Max(g => g.Count());
            var modes = groupedNumbers.Where(g => g.Count() == maxFrequency).Select(g => g.Key).OrderBy(n => n).ToList();


            Console.Write("numbers: ");
            foreach (int num in sortedNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mean from numbers: " + mean);
            Console.WriteLine("Median from numbers: " + median);
            Console.WriteLine("Modus from numbers: " + string.Join(", ", modes));
        }
    }
}
