using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class FindTheLargestNumberInAGroupOfArrays
    {
        public static int[] FindLargest(int[][] arrays)
        {
            var arrayCount = arrays.Length;
            var largestArr = new int[arrayCount];
            for (var i = 0; i < arrays.Length; i++)
            {
                largestArr[i] = arrays[i].Max();
            }
            return largestArr;
        }
    }
}
