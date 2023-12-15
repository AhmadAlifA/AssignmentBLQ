using System;

namespace No._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] jamMakan = { 9, 13, 15, 17 };
            int[] kalori = { 30, 20, 50, 80 };

            int waktuMulaiOlahraga = 18;

            int totalKalori = HitungTotalKalori(kalori);

            double durasiOlahraga = HitungDurasiOlahraga(jamMakan, waktuMulaiOlahraga);

            int jumlahAir = HitungJumlahAir(durasiOlahraga);

            Console.WriteLine($"Total kalori yang dikonsumsi: {totalKalori} kalori");
            Console.WriteLine($"Durasi olahraga: {durasiOlahraga} jam");
            Console.WriteLine($"Jumlah air yang diminum: {jumlahAir} cc");
        }

        static int HitungTotalKalori(int[] kalori)
        {
            int total = 0;
            foreach (int kaloriSatuan in kalori)
            {
                total += kaloriSatuan;
            }
            return total;
        }

        static double HitungDurasiOlahraga(int[] jamMakan, int waktuMulaiOlahraga)
        {
            int waktuTerakhirMakan = jamMakan[jamMakan.Length - 1];
            return waktuMulaiOlahraga - waktuTerakhirMakan;
        }

        static int HitungJumlahAir(double durasiOlahraga)
        {
            int jumlahAirPer30Menit = (int)(durasiOlahraga / 0.5) * 100;

            int jumlahAirAkhirOlahraga = 500;

            return jumlahAirPer30Menit + jumlahAirAkhirOlahraga;
        }
    }
}
