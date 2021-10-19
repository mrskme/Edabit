using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Edabit
{
    class ReverseString
    {
        //1
        public static string ReverseStr(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
        //2
        public static string ReverseStrWithNames(string str)
        {
            var charArr = str.ToCharArray();
            var reversedCharIenumerable = charArr.Reverse();
            var reversedCharaArray = reversedCharIenumerable.ToArray();
            var reversedString = new string(reversedCharaArray);
            return reversedString;
        }
        //3
        public static string ReverseStringWithOppdeling(string str)
        {
            var charIEnumerable = ToChars(str);
            var reversedCharIenumerable = ReverseChars(charIEnumerable);
            var reversedCharaArray = CharIEnumerableToArray(reversedCharIenumerable); 
            var reversedString = MakeStringFromCharArray(reversedCharaArray);
            return reversedString;
        }
        private static IEnumerable<char> ToChars(string str) 
            => str.ToCharArray();

        private static IEnumerable<char> ReverseChars(IEnumerable<char> charArr) 
            => charArr.Reverse();

        private static string MakeStringFromCharArray(char[] reversedCharaArray) 
            => new string(reversedCharaArray);

        private static char[] CharIEnumerableToArray(IEnumerable<char> reversedCharIenumerable) 
            => reversedCharIenumerable.ToArray();
    }
}
