using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void DisplayFirstNFibonacciNumbers(int n)
            {
                int first = 0, second = 1;

                Console.Write($"{n} bilangan Fibonacci pertama adalah: ");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(first + " ");

                    int temp = first;
                    first = second;
                    second = temp + second;
                }

                Console.WriteLine();
            }

             int n = 10;
             DisplayFirstNFibonacciNumbers(n);
        }
    }
}
