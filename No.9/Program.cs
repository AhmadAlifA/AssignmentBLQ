using System;

namespace No._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateSequence(3); // Example for N = 3
            GenerateSequence(4); // Example for N = 4
            GenerateSequence(5); // Example for N = 5
        }

        static void GenerateSequence(int N)
        {
            Console.Write($"N = {N} \t-> ");

            for (int i = 1; i <= N; i++)
            {
                int result = N * i;
                Console.Write(result + " ");
            }

            Console.WriteLine();
        }
    }
}
