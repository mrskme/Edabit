using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit.Expert.ExcelSheetColumn
{
    public class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string str)
        {
            var intList = new List<int>();
            foreach (var character in str)
            {
                var characterAsNumber = character - 64;
                intList.Add(characterAsNumber);
            }

            foreach (var asd in intList)
            {
                Console.WriteLine(asd);
            }
            int number = intList.Aggregate((a, x) => a * x);
            return number;
        }
    }
}
