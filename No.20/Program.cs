using System;
using System.Collections.Generic;

namespace No._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permainan Suit Gunting Batu Kertas");

            int jarakAwal = 2;
            string suitA = "GGG", suitB = "KKB";

            Dictionary<string, int> aturanSuit = new Dictionary<string, int>
            {
            {"GB", 2}, {"BK", 2}, {"KG", 2},
            {"BG", -1}, {"KB", -1}, {"GK", -1}
            };

            string pemenang = TentukanPemenang(jarakAwal, suitA, suitB, aturanSuit);

            Console.WriteLine($"Pemenang: {pemenang}");
        }
        static string TentukanPemenang(int jarakAwal, string suitA, string suitB, Dictionary<string, int> aturanSuit)
        {
            int jarakAntaraAB = jarakAwal;
            for (int i = 0; i < suitA.Length; i++)
            {
                string kombinasiSuit = $"{suitA[i]}{suitB[i]}";
                if (aturanSuit.ContainsKey(kombinasiSuit))
                {
                    jarakAntaraAB += aturanSuit[kombinasiSuit];
                    Console.WriteLine(jarakAntaraAB);
                }
                if (jarakAntaraAB == 0)
                {
                    return "A";
                }
            }
            return "Draw";
        }
    }
}
