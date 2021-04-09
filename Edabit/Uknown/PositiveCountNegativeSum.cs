using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class PositiveCountNegativeSum
    {
        public static int[][] dummy =
        {
            new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15},
            new[] {92, 6, 73, -77, 81, -90, 99, 8, -85, 34},
            new[] {91, -4, 80, -73, -28},
            new int[0],
        };

        public static int[] CountPosSumNeg(int[] numbers)
        {
            int count = 0;
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num > 0) count++;
                else sum += num;
            }

            var arr = new[] {count, sum};
            return arr;
        }
    }
}
