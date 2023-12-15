using System;
using System.Collections.Generic;
using System.Linq;

namespace No._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxPayAndItem();
        }

        static void MaxPayAndItem()
        {
            string[] items = { "kacamata", "baju", "sepatu", "buku" };
            int[][] priceListComb =
            {
            new int[] { 500, 200, 400, 100 },
            new int[] { 600, 400, 350, 50 },
            new int[] { 700, 350, 200, 150 },
            new int[] { 800, 0, 300, 0 }
        };

            var result = priceListComb.Select(v =>
            {
                var text = new List<string>();
                for (int k1 = 0; k1 < v.Length; k1++)
                {
                    if (v[k1] > 0)
                    {
                        text.Add(items[k1] + ": " + v[k1]);
                    }
                }

                return new
                {
                    ItemCount = v.Count(x => x > 0),
                    TotalPay = v.Sum(),
                    Text = string.Join(", ", text)
                };
            })
            .OrderByDescending(x => x.TotalPay + x.ItemCount)
            .ToList();

            int maxPay = result.First().TotalPay;
            int maxItemCount = result.First().ItemCount;

            Console.WriteLine($"Jumlah uang yang dipakai: {maxPay}\n");
            Console.WriteLine($"Jumlah item yang bisa dibeli: {maxItemCount}\n");
            Console.WriteLine("Kombinasi item yang bisa dibeli:\n");

            result.Where(x => x.TotalPay == maxPay && x.ItemCount == maxItemCount)
                  .ToList()
                  .ForEach(x => Console.WriteLine($"- {x.Text}\n"));
        }
    }
}
