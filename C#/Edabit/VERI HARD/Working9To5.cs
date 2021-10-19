using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit.VERI_HARD
{
    class Working9To5
    {
        public static string OverTime(double[] ints)
        {
            var startingTimeInt = Convert.ToInt32(ints[0]);
            var endOfWorkDayInt = Convert.ToInt32(ints[1]);
            var hourlyRateInt = Convert.ToInt32(ints[2]);
            var overtimeMultiplier = ints[3];

            var hours = GetCountOfWorkHoursType(startingTimeInt, endOfWorkDayInt);
            var normalHours = hours[0];
            var overtimeHours = hours[1];

            var overTimePay = overtimeHours * overtimeMultiplier * hourlyRateInt;
            var normalPay = normalHours * hourlyRateInt;
            var totalPay = overTimePay + normalPay;

            return "$" + totalPay + ".00";
        }

        private static int[] GetCountOfWorkHoursType(int startingTimeInt, int endOfWorkDayInt)
        {
            var allHours = Enumerable.Range(startingTimeInt, endOfWorkDayInt - startingTimeInt);
            var overTimeHoursCount = 0;
            foreach (var hour in allHours)
            {
                Console.WriteLine(hour);
                var isNormalHour = hour >= 9 && hour < 17;
                Console.WriteLine(isNormalHour);
                if (!isNormalHour)
                {
                    overTimeHoursCount++;
                }
            }
            var totalHoursWorkday = endOfWorkDayInt - startingTimeInt;
            var normalHours = totalHoursWorkday - overTimeHoursCount;
            return new [] {normalHours, overTimeHoursCount};
        }
    }
}
