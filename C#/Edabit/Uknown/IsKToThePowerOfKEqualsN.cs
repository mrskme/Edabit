using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class IsKToThePowerOfKEqualsN
    {
        public static bool KToK(string n, int k) => 
            Convert.ToInt32(Math.Pow(k, k)) == Convert.ToInt32(n);
    }
}
