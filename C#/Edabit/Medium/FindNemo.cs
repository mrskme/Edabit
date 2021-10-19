using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit.Medium
{
    class FindNemo
    {
        //https://edabit.com/challenge/ynZfn2LifKN25fP84w

        public static string FindingNemo(string str)
        {
            var words = str.Split(" ");
            for (var i = 0; i < words.Length; i++)
            {
                if (!words[i].Contains("Nemo"))
                {
                    continue;
                };
                return $"I found nemo at {i + 1}!";
            }
            return "no nemo was found";
        }
    }
}