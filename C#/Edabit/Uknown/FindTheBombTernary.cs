using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class FindTheBombTernary
    {
        public static string FindTheBomb(string sentence) 
            => sentence.ToLower().Contains("bomb") ? "Duck!!!" : "Relax there is no bomb here";
    }
}
