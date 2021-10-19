using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    class BasicEmailValidation
    {
        public static bool ValidateEmail(string email)
        {
            var indexOfAt = email.IndexOf("@", StringComparison.Ordinal);
            var indexOfDot = email.LastIndexOf(".", StringComparison.Ordinal);

            if (indexOfDot == -1) return false;
            if (indexOfAt <= 0) return false;
            return indexOfAt < indexOfDot;
        }
    }
}
