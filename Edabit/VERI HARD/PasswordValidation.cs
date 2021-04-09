using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit.VERI_HARD
{
    class PasswordValidation
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length > 24 || password.Length < 6) return false;
            var uppercase = new Regex("[A-Z]");
            var lowerCase = new Regex("[a-z]");
            var digits = new Regex("[0-9]");
            if (!uppercase.IsMatch(password) || !lowerCase.IsMatch(password) || !digits.IsMatch(password)) return false;
            var specialCharacters = new Regex("[?\\-!@#$%^&*()+=_{}[\\]:;\"'<>,\\.]");
            if (!specialCharacters.IsMatch(password)) return false;
            return true;
        }
        public static bool ValidatePassword2(string password)
        {
            if (password.Length > 24 || password.Length < 6) return false;
            if (!password.Any(c => char.IsUpper(c) && char.IsDigit(c) && char.IsLower(c))) return false;
            if (!password.Any(c => char.IsUpper(c)) || !password.Any(c => char.IsLower(c)) || !password.Any(c => char.IsDigit(c))) return false;

            return true;
        }
    }
}
