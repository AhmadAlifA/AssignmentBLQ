using System;

namespace BilPrima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool IsPrime(int num)
            {
                if (num < 2)
                    return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }

            static void DisplayFirstNPrimes(int n)
            {
                int count = 0;
                int num = 2;

                Console.Write($"{n} bilangan prima pertama adalah: ");
                while (count < n)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                        count++;
                    }
                    num++;
                }
                Console.WriteLine();
            }

            int n = 10;
            DisplayFirstNPrimes(n);
        }
    }
}
