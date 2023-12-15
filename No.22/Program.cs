using System;
using System.Collections.Generic;
using System.Linq;

namespace No._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = FirstCandle(new List<int> { 3, 3, 9, 6, 7, 8, 23 });
            Console.WriteLine(string.Join(", ", result));
        }

        static List<int> FirstCandle(List<int> candleList)
        {
            int b1 = 0;
            int b2 = 1;

            var result = candleList.Select(v =>
            {
                int tempB1 = b1;
                b1 = b2;
                b2 = b2 + tempB1;
                return new { val = v, dur = (double)v / b1 };
            })
            .OrderBy(x => x.dur)
            .ToList();

            double minDuration = result.First().dur;

            return result
                .Where(x => Math.Abs(x.dur - minDuration) < double.Epsilon)
                .Select(x => x.val)
                .ToList();
        }
    }
}
