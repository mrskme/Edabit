using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Edabit
{
    class PerfectSquare
    {
        public static int[][] MakeSquare(int number)
        {
            int[][] arrays = new int[number][];
            for (var i = 0; i < arrays.Length; i++)
            {
                arrays[i] = new int[number];
                for (var j = 0; j < arrays[i].Length; j++)
                {
                    arrays[i][j] = number;
                }
            }
            return arrays;
        }





        public static void WriteSquare(int number)
        {
            var r = MakeSquare(number);
            foreach (var array in r)
            {
                foreach (var arr in array)
                {
                    Console.Write(arr);
                }
                Console.WriteLine();
            }
        }
    }
}
