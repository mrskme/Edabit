using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class ReturnHighestAndLowestNumbers
    {
        public static string HighLow(string numbers)
        {
            var numbersAsInt = Array.ConvertAll(numbers.Split(" "), s => Convert.ToInt32(s));
            return numbersAsInt.Min() + " " + numbersAsInt.Max();
        }
    }
}
