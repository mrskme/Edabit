using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class IPv4Validation
    {
        //https://edabit.com/challenge/BNKRr4N2oFZQfrTY3
        public static bool IsValidIp(string ip)
        {
            if (ip[^1] == '0') return false;
            var numbers = ip.Split(".");
            if (numbers.Length != 4) return false;
            foreach (var number in numbers)
            {
                if (number[0] == '0') return false;
                if (!int.TryParse(number, out var intnum)) return false;
                if (intnum < 1 || intnum > 255) return false;
            }
            if (ip.Last().Equals('0')) return false;
            return true; 
        }
    }
}
