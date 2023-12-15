using System;

namespace No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tanggalPeminjamanA = new DateTime(2016, 2, 28);
            DateTime tanggalPengembalianA = new DateTime(2016, 3, 7);
            int[] durasiPeminjamanA = { 14, 3, 7, 7 };

            int totalDendaA = HitungDenda(tanggalPeminjamanA, durasiPeminjamanA, tanggalPengembalianA);

            Console.WriteLine($"Denda pada rentang waktu a: {totalDendaA} IDR");

            DateTime tanggalPeminjamanB = new DateTime(2018, 4, 29);
            DateTime tanggalPengembalianB = new DateTime(2018, 5, 30);
            int[] durasiPeminjamanB = { 14, 3, 7, 7 };

            int totalDendaB = HitungDenda(tanggalPeminjamanB, durasiPeminjamanB, tanggalPengembalianB);

            Console.WriteLine($"Denda pada rentang waktu b: {totalDendaB} IDR");
        }

        static int HitungDenda(DateTime tanggalPeminjaman, int[] durasiPeminjaman, DateTime tanggalPengembalian)
        {
            int totalDenda = 0;

            for (int i = 0; i < durasiPeminjaman.Length; i++)
            {
                DateTime batasPengembalian = tanggalPeminjaman.AddDays(durasiPeminjaman[i]);

                if (tanggalPengembalian > batasPengembalian)
                {
                    int selisihHari = (int)(tanggalPengembalian - batasPengembalian).TotalDays;
                    totalDenda += selisihHari * 100;
                }
            }

            return totalDenda;
        }
    }
}
