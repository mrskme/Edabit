using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit.VERI_HARD
{
    class ConsecutiveNumbersTWO
    {
        //https://edabit.com/challenge/ywHrStmf93Thm3x3B

        public static bool testy(int[] arr, int number, int times)
        {
            return arr.GroupBy(a => a).Any(b => b.Key == number && b.Count() == times);
        }
        public static bool IsThereConsecutiveNumberinos(int[] arr, int number, int times)
        {
            var count = 0;
            foreach (var n in arr)
            {
                if (!n.Equals(number))
                {
                    count = 0;
                    continue;
                }
                count++;
                if (count.Equals(times)) return true;
            }
            return times.Equals(0);
        }
    }
}
