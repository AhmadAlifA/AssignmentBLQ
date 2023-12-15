using System;

namespace No._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Susilo Bambang Yudhoyono", word2 = "Rani Tiara";
            Console.WriteLine(word1 + " : " + MaskString(word1));
            Console.WriteLine(word2 + "\t\t : " + MaskString(word2));
        }

        static string MaskString(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > 2)
                {
                    words[i] = word[0] + new string('*', word.Length - 2) + word[^1];
                }
            }

            return string.Join(' ', words);
        }
    }
}
