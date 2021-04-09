using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class DoAllBiagramsExsist
    {
        public static bool CanFind(string[] biagrams, string[] words)
        {
            foreach (var biagram in biagrams)
            {
                if (words.Any(w => w.Contains(biagram)))
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        public static bool CanFindLinq(string[] biagrams, string[] words)
            => biagrams.All(biagram => words.Any(w => w.Contains(biagram)));
        
    }
}
