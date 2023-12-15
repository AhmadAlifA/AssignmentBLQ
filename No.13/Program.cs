using System;

namespace No._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string times1 = "3:00";
            Console.Write($"Jam {times1} -> ");
            Angle(times1);
            string times2 = "5:30";
            Console.Write($"Jam {times2} -> ");
            Angle(times2);
            string times3 = "2:20";
            Console.Write($"Jam {times3} -> ");
            Angle(times3);
        }

        static void Angle(string time)
        {
            string[] timeSplit = time.Split(':');
            double hours = Convert.ToInt32(timeSplit[0]) % 12;
            double minutes = Convert.ToInt32(timeSplit[1]) % 60;
            double angle = Math.Abs(30 * hours - (11.0 / 2) * minutes);
            Console.WriteLine(angle + "∘");
        }
    }
}
