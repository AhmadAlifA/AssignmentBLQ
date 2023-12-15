using System;
using System.Collections.Generic;
using System.Linq;

namespace No._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kalimat1 = "Sphinx of black quartz, judge my vow";
            string kalimat2 = "Brawny gods just flocked up to quiz and vex him";
            string kalimat3 = "Check back tomorrow; I will see if the book has arrived.";

            Console.WriteLine($"Kalimat 1 adalah pangram: {IsPangram(kalimat1)}");
            Console.WriteLine($"Kalimat 2 adalah pangram: {IsPangram(kalimat2)}");
            Console.WriteLine($"Kalimat 3 adalah pangram: {IsPangram(kalimat3)}");
        }

        static bool IsPangram(string kalimat)
        {
            string kalimatBersih = "";
            foreach (char karakter in kalimat)
            {
                if (Char.IsLetter(karakter))
                {
                    kalimatBersih += Char.ToLower(karakter);
                }
            }

            HashSet<char> hurufUnik = new HashSet<char>();
            foreach (char huruf in kalimatBersih)
            {
                hurufUnik.Add(huruf);
            }

            return hurufUnik.Count == 26;
        }
    }
}
