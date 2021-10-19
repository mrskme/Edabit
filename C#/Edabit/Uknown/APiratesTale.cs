using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    internal class APiratesTale
    {
        public static int NumberOfDays(int[] coordinates)
        {
            var numberOfDays = 0;
            foreach (var coordinate in coordinates)
            {
                
                for (var i = 0; i < Math.Abs(coordinate); i++)
                {
                    
                    numberOfDays++;
                    if (numberOfDays % 6 == 0) numberOfDays++;
                }
            }
            return numberOfDays;
        }

        public static void MakeResult(int[] coordinates)
        {
            var r = NumberOfDays(coordinates);
            Console.WriteLine(r);
        }
    }
}
