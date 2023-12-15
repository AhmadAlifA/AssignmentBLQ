using System;

namespace No._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time12Hours = "03:40:44 PM";

            string time24Hours = ConvertTo24HourFormat(time12Hours);

            Console.WriteLine("Tim format in 24 Hour: " + time24Hours);

        }

        static string ConvertTo24HourFormat(string time12Hours)
        {
            string[] splitTime = time12Hours.Split(':');
            int hour12 = int.Parse(splitTime[0]);
            int minutes = int.Parse(splitTime[1].Substring(0, 2)); 
            string amPm = splitTime[2].Substring(3, 2); 
            int seconds = int.Parse(splitTime[2].Substring(0, 2));

            if (amPm == "PM" && hour12 != 12)
            {
                hour12 += 12;
            }

            string time24Hours = $"{hour12:D2}:{minutes:D2}:{seconds:D2}";

            return time24Hours;
        }
    }
}
