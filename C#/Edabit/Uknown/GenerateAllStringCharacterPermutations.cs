using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class GenerateAllStringCharacterPermutations
    {
        public static string Permutations(string str)
        {
            var permutationsArray = new List<string>();

            var permutations = string.Empty;
            foreach (var character in str)
            {
                for (var j = 0; j < str.Length - 1; j++)
                {
                    if (character == str[j + 1]) continue;
                    var permutationArrayA = new [] {character, str[j + 1]};
                    var permutationArrayB = new[] { str[j + 1], character };
                    var permutationA = new string(permutationArrayA);
                    var permutationB = new string(permutationArrayB);
                    foreach (string permu in permutationsArray)
                    {
                        if (!permutationA.Contains(permu))
                        {
                            permutationsArray.Add(permutationA);
                        }
                        if (!permutationB.Contains(permu))
                        {
                            permutationsArray.Add(permutationB);
                        }
                    }
                    
                    permutationsArray.Add(permutationB);
                }
            }
            foreach (var permutation in permutationsArray)
            {
                permutations += permutation + " ";
            }
            return permutations;
        }
    }
}
