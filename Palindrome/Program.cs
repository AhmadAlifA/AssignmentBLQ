using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static bool IsPalindrome(string word)
            {
                int length = word.Length;

                for (int i = 0; i < length / 2; i++)
                {
                    if (word[i] != word[length - i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }

            string word1 = "kattak";
            string word2 = "hello";

            Console.WriteLine($"{word1} {(IsPalindrome(word1) ? "is" : "not")} palindrome.");
            Console.WriteLine($"{word2} {(IsPalindrome(word2) ? "is" : "not")} palindrome.");
        }
    }
}
