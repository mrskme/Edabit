using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit.VERI_HARD
{
    class JoakimConsecc
    {
        public bool IsConsequtiveOrder(int[] numbers, int n, int tresholdCount)
            {
                var shiftedInts = new List<int>();
                var consequtiveCount = 1;
                bool isConsecutive = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = numbers[i];
                    int shiftedInt = shiftedInts[i];
                    if (number == shiftedInt && number == n)
                    {
                        consequtiveCount++;
                        int offset = -1;
                        List<int> shiftedInts2 = new();
                            for (int j = consequtiveCount; j < numbers.Length; j++)
                            { 
                                int numberino = numbers[i];
                                shiftedInts2.Add(number);
                                shiftedInts2.Add(offset);
                            }
                        shiftedInts = shiftedInts2;
                    }
                    if (consequtiveCount == tresholdCount)
                    {
                        isConsecutive = true;
                        break;
                    }
                }
                return isConsecutive;
            }
    }
}
