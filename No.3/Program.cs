using System;

namespace No._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime masuk1 = new DateTime(2019, 1, 27, 5, 0, 1);
            DateTime keluar1 = new DateTime(2019, 1, 27, 17, 45, 3);

            DateTime masuk2 = new DateTime(2019, 1, 27, 7, 3, 59);
            DateTime keluar2 = new DateTime(2019, 1, 27, 15, 30, 6);

            DateTime masuk3 = new DateTime(2019, 1, 27, 7, 5, 0);
            DateTime keluar3 = new DateTime(2019, 1, 28, 0, 20, 21);

            DateTime masuk4 = new DateTime(2019, 1, 27, 11, 14, 23);
            DateTime keluar4 = new DateTime(2019, 1, 27, 13, 20, 0);

            Console.WriteLine($"Tarif parkir 1: {HitungTarifParkir(masuk1, keluar1)}");
            Console.WriteLine($"Tarif parkir 2: {HitungTarifParkir(masuk2, keluar2)}");
            Console.WriteLine($"Tarif parkir 3: {HitungTarifParkir(masuk3, keluar3)}");
            Console.WriteLine($"Tarif parkir 4: {HitungTarifParkir(masuk4, keluar4)}");
        }

        static int HitungTarifParkir(DateTime masuk, DateTime keluar)
        {
            TimeSpan durasi = keluar - masuk;
            int tarif = 0;

            // 8 jam pertama: 1.000/jam
            if (durasi.TotalHours <= 8 )
            {
                tarif = (int)durasi.TotalHours * 1000;
                if(durasi.TotalMinutes % 60 > 0)
                    tarif += 1000;
            }
            // 8 jam 1 detik - 24 jam: 8.000 flat
            else if (durasi.TotalHours <= 24)
            {
                tarif = 8000;
            }
            // 24 jam 1 detik – 8 jam kemudian: 15.000 flat + 1.000/jam
            else
            {
                tarif = 15000 + (int)(durasi.TotalHours - 24) * 1000;
                if (durasi.TotalMinutes % 60 > 0)
                    tarif += 1000;
            }

            return tarif;
        }
    }
}
