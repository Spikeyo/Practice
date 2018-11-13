//****************************************************************
// Solution for the NucleotideCount exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System;
using System.Collections.Generic;

namespace Nucleotide
{
    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            var count = new Dictionary<char, int>(4)
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };

            foreach (char c in sequence)
            {
                if (count.TryGetValue(c, out int value))
                {
                    count[c]++;
                }
                else
                {
                    throw new ArgumentException(nameof(sequence), 
                        $"sequence contains invalid char: {c}");
                }
            }
        
            return count;
        }
    }
}
