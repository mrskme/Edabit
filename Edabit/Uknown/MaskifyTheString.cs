using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class MaskifyTheString
    {
        //https://edabit.com/challenge/RFeBL2TzSf7mRMNJi
        public static string Maskify(string str)
        {
            var returnstr = str;
            var strLength = str.Length;
            if (strLength > 4) returnstr = returnstr.Remove(0, strLength-4);
            returnstr = returnstr.PadLeft(strLength, '#');
            return returnstr;
        }

        public static string MaskifyOneLiner(string str) =>
            str.Length > 4 
                ? str
                    .Remove(0, str.Length - 4)
                    .PadLeft(str.Length, '#') 
                : str;
    }
}
