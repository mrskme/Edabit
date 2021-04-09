using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class ReverseTheCase
    {
        public static string ReverseCase(string str = "", string seed = "")
            => str.Aggregate(seed, (current, character) 
                => current + (char.IsLower(character) 
                    ? char.ToUpper(character) 
                    : char.ToLower(character)));
        }
    
}
