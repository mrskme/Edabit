using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit.Medium
{
    class KarcasEncryption
    {
        //https://edabit.com/challenge/TLWqG49uMLa7zgxPE
        public static string Encrypt(string word)
        {
            var reversed = new string(word.Reverse().ToArray());

            var vowels = new string[]
            {
                "a",
                "e",
                "i",
                "o",
                "u",
            };
            var numbers = new string[]
            {
                "0",
                "1",
                "2",
                "2",
                "3",
            };
            reversed = vowels.Zip(numbers, (a, b) => new {A = a, B = b}).Aggregate(reversed, (current, pair) => current.Replace(pair.A, pair.B));
            return reversed + "aca";
        }
    }
}
