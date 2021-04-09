using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    class ScottishScreaming
    { 
        public static string ToScottishScreaming(string str) =>
            new Regex("[aeiou]").Replace(str, "E").ToUpper();
    }
}
