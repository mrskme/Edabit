using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Edabit
{
    class IsPerfectOrAmicable
    {
        public static string NumType(long x)
        {
            Console.WriteLine(x);
            var xDivisors = GetIntegerDivisors(x);
            var xDivisorsSum = xDivisors.Sum();
            if (xDivisorsSum == x) return "Perfect"; 
            
            var y = GetIntegerDivisors(xDivisorsSum);
            var yDivisorsSum = y.Sum();

            return yDivisorsSum == x ? "Amicable" : "Neither";
        }

        public static string NumTypeOneLiner(long x) //4 funz
            => GetIntegerDivisors(x).Sum() == x ?
                "Pefect" : 
                GetIntegerDivisors(GetIntegerDivisors(x).Sum()).Sum() == x ?
                    "Amicable" : 
                    "Neither";
        
        private static IEnumerable<long> GetIntegerDivisors(long number)
        {
            long numberWithDecimal = number;
            var divisors = new List<long>();
            for (var i = 1; i < numberWithDecimal; i++)
            {
                if (numberWithDecimal % i != 0) continue;
                divisors.Add(i);
            }
            return divisors;
        }
    }
    public class AmicableCalc
    {
        private int _x; // input number
        private int _y; // divisor-sum
        private readonly short[] _a = { 0, 0, 0, 0 };
        // A = { [0] = Perfect, [1] = Lesser amicable, [2] = Greater Amicable, [3] = Neither } 
        public AmicableCalc(int x)
        {
            _x = x;
        }

        public void SumDivisors()
        {
            for (int i = 1; i <= _x; i++) _y += _x / i;
        }

        public void IsPerfect()
        {
            if (_x == _y) _a[0] = 1;
        }

        public void CheckAmicable()
        {
            if (_y > _x) IsAmicable(true);
            if (_y < _x) IsAmicable(false);
        }

        private void IsAmicable(bool index) // 220 -> 284
        {
            bool isLesser = index;
            int x1 = _x;
            _x = _y;
            _y = 0;
            SumDivisors();
            if (x1 == _x && isLesser) _a[1] = 1;
            if (x1 == _x && !isLesser) _a[2] = 1;
            if (x1 != _x && _a[0] == 0) _a[3] = 1;
        }

        public void Print()
        {
            if (_a[0] == 1) Console.Write("Perfect number!");
            if (_a[1] == 1) Console.Write("Lesser of amicable pair!");
            if (_a[2] == 1) Console.Write("Greater of amicable pair!");
            if (_a[3] == 1) Console.Write("Neither!");
        }
    }
}
