using System;

namespace No._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string perjalananHattori = "NNTNNNTTTTTNTTTNT";

            int jumlahGunung = HitungGunungLembah(perjalananHattori, 'N');
            int jumlahLembah = HitungGunungLembah(perjalananHattori, 'T');

            HitungGunungLembah2(perjalananHattori);

            Console.WriteLine($"Jumlah Gunung: {jumlahGunung}");
            Console.WriteLine($"Jumlah Lembah: {jumlahLembah}");
        }

        static int HitungGunungLembah(string perjalanan, char simbol)
        {
            int ketinggian = 0;
            int jumlah = 0;

            foreach (char langkah in perjalanan)
            {
                if (langkah == simbol)
                {
                    ketinggian++;
                }
                else
                {
                    ketinggian--;

                    if (ketinggian == 0)
                    {
                        jumlah++;
                    }
                }
            }

            return jumlah;
        }

        static void HitungGunungLembah2(string perjalanan)
        {
            int ketinggian = 0;
            int up = 0, down = 0;

            foreach (char langkah in perjalanan)
            {
                if (langkah == 'N')
                {
                    ketinggian++;
                    if (ketinggian == 0)
                    {
                        down++;
                    }
                }
                else
                {
                    ketinggian--;

                    if (ketinggian == 0)
                    {
                        up++;
                    }
                }
            }
            Console.WriteLine($"Jumlah Gunung: {up}");
            Console.WriteLine($"Jumlah Lembah: {down}");
        }
    }
}
