using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Algorithms
{
    public class Candles
    {
        public int BirthdayCakeCandles(List<int> candles)
        {
            var sortedCandles = candles.OrderByDescending(x => x).ToList();

            int tallest = sortedCandles[0];
            int count = 1;

            for (int i = 1; i < sortedCandles.Count; i++)
            {
                if (sortedCandles[i] == tallest)
                    count++;
            }

            return count;
        }
    }
}