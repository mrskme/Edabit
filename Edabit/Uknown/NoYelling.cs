using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Edabit
{
    class NoYelling
    {
        // https://edabit.com/challenge/ToMXLjWDLQqFua7Wh
        public static string NoYell(string str)
        {
            var words = str.Split(" ");
            var newSentence = string.Empty;
            foreach (var word in words)
            {
                if (word.Contains("?"))
                {
                    newSentence += WordWithoutMultipleSymbols(word, "?");
                }
                if (word.Contains("!"))
                {
                    newSentence += WordWithoutMultipleSymbols(word, "!");
                }
            }
            return newSentence;
        }

        private static string WordWithoutMultipleSymbols(string word, string symbol)
            => word.Replace(symbol, "") + symbol + " ";


        //public static string NoYellOriginal(string str)
        //{
        //    var words = str.Split(" ");
        //    var newSentence = string.Empty;
        //    foreach (var word in words)
        //    {
        //        for (var i = 0; i < word.Length; i++)
        //        {
        //            var character = word[i];
        //            if (!character.Equals('?') || !character.Equals('!')) //No funk
        //            {
        //                continue;
        //            }
        //            var firstSymbolIndex = i;
        //            var wordWithoutMultipleSymbols = word.Substring(0, firstSymbolIndex);
        //            newSentence += wordWithoutMultipleSymbols + " ";
        //            break;
        //        }
        //    }
        //    return newSentence;
        //}

        public static string OmegaLinqNoYell(string str)
            => str
                .Split(" ")
                .Aggregate(string.Empty, (current, word) => current + (word.Contains("?")
                    ? word.Replace("?", "") + "?" + " "
                    : word.Contains("!")
                        ? word.Replace("!", "") + "!" + " "
                        : word + " "));
    }
}
