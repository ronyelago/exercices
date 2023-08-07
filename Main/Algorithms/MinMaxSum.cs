using System.Reflection.Emit;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Algorithms
{
    public class MinMaxSum
    {
        public int MinSum(List<int> numbers)
        {
            numbers.Sort();
            int minSum = 0;

            for (int i = 0; i < 4; i++)
            {
                minSum += numbers[i];
            }

            return minSum;
        }

        public int MaxSum(List<int> numbers)
        {
            numbers.Sort();
            int maxSum = 0;

            for (int i = numbers.Count - 1; i >= numbers.Count -4; i--)
            {
                maxSum += numbers[i];
            }

            return maxSum;
        }
    }
}