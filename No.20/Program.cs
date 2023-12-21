using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace No._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permainan Suit Gunting Batu Kertas");

            int jarakAwal = 2;
            //string suitA = "GGG", suitB = "KKB";
            string suitA = "KKB", suitB = "GGG";

            Dictionary<string, int> aturanSuit = new Dictionary<string, int>
            {
            {"GB", -1}, {"BK", -1}, {"KG", -1},
            {"BG", 2}, {"KB", 2}, {"GK", 2}
            };

            string pemenang = TentukanPemenang(jarakAwal, suitA, suitB, aturanSuit);

            Console.WriteLine($"Pemenang: {pemenang}");
        }
        static string TentukanPemenang(int jarakAwal, string suitA, string suitB, Dictionary<string, int> aturanSuit)
        {
            int posisiA = (int) Math.Ceiling((double)jarakAwal / 2);
            int posisiB = posisiA - jarakAwal; 
            for (int i = 0; i < suitA.Length; i++)
            {
                if (suitA[i] != suitB[i])
                {
                    string kombinasiSuit = $"{suitA[i]}{suitB[i]}";
                    string kombinasiSuit1 = $"{suitB[i]}{suitA[i]}";

                    posisiA -= aturanSuit[kombinasiSuit];
                    posisiB += aturanSuit[kombinasiSuit1];
                        Console.WriteLine(posisiA + " || " +posisiB);
                    if (posisiA < posisiB || posisiA - posisiB == 0 )
                    {
                        return aturanSuit[kombinasiSuit] == 2 ? "A" : "B"; 
                    }
                }
            }
            return "Draw";
        }
    }
}
