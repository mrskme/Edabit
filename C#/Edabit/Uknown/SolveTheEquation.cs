using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace Edabit
{
    class SolveTheEquation
    {
        public static object Equation(string equation)
            => new DataTable().Compute(equation, "");
    }
}
