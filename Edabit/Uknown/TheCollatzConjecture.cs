using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class TheCollatzConjecture
    {
        public static int Collatz(int n)
        {
            int number = n;
            int stepsCount = 0;
            while (number != 1)
            {
                number =
                    number % 2 == 0 ? 
                    number / 2 :
                    number * 3 + 1; ;
                stepsCount++;
            }

            return stepsCount;
        }
    }
}
