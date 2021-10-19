using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    class ReverseCodingChallange1
    {
        //https://edabit.com/challenge/bqveyPRgcWZM7XzMQ

        public static string MysteryFuncSøvnInspirert(string str)
        {
            var padString = string.Empty;
            var amounts = new List<int>();
            var characters = new List<char>();
            foreach (var character in str)
            {
                if (int.TryParse(character.ToString(), out int number)) amounts.Add(number);
                else characters.Add(character);
            }

            var result = characters
                .Select((character, amount) 
                    => padString.PadLeft(padString.Length + amounts[amount], character))
                .Aggregate((i, j) => i + j);

            return result;
        }

        //public static string MysteryFunc(string str)
        //{
        //    var returnstr = string.Empty;
        //    Regex allNumbers = new Regex(@"[0-9]");
        //    Regex allLetters = new Regex("[a-zA-Z]");

        //    var numbers = allLetters.Split(str).ToList();
        //    numbers.Remove((""));
        //    var letters = allNumbers.Split(str).ToList();
        //    letters.Remove("");

        //    var charLetters = string.Join(null,letters).ToCharArray();
        //    for (int i = 0; i < letters.Count; i++)
        //    {
        //        if (!int.TryParse(numbers[i], out var number)) return $"notParsable + {number}";
        //        returnstr += returnstr.PadRight(number, charLetters[i]);
        //    }
        //    return returnstr;
        //}

        //public static string MysteryFuncDanicaInspirert(string str)
        //{
        //    var isNumer = str.Length % 2 == 0;
        //}
    }
}
