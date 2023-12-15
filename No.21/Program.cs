using System;
using System.Collections.Generic;

namespace No._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BtM("wwwwjj"));
        }

        static string BtM(string wj)
        {
            int[] track = { 0, 0, 0, 0, 0, -1, 1, 1, 1 };
            int s = 0;
            int d = 0;
            string sf = "SUCCESS";

            foreach (char v in wj)
            {
                if (v == 'w')
                {
                    s += 1;
                    d += 1;
                }
                else
                {
                    s -= 2;
                    d += 3;
                }

                int totD = d >= track.Length ? 1 : track[d - 1];
                if (totD == -1 || (s <= 0 && totD == 0))
                {
                    sf = "FAILED";
                    break;
                }
            }

            return sf;
        }
    }
}
