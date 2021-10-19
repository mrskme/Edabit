using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class GreatestCommonDivisor
    {
        public static int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a | b;
        }
    }
}
