using System;

namespace No._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Afrika", input2 = "Jeruk";
            Console.WriteLine("Input: " + input1);
            DisplayPattern(input1);

            Console.WriteLine("\nInput: " + input2);
            DisplayPattern(input2);
        }

        static void DisplayPattern(string input)
        {
            int length = input.Length/2;
            string line = new string('*', length);

            for (int i = 0; i < input.Length; i++)
            {
                string word = line + input[i] + line;
                Console.WriteLine(word);
            }
        }
    }
}
