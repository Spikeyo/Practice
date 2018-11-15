//*************************************************************
// Solution for the ProteinTranslation exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace ProteinTranslationProject
{
    public static class ProteinTranslator
    {
        private static readonly IReadOnlyDictionary<string, IReadOnlyList<string>>
                 ProteinsPerCodons = new Dictionary<string, IReadOnlyList<string>>
            {
                ["Methionine"]    = new List<string> {"AUG"},
                ["Phenylalanine"] = new List<string> {"UUU", "UUC"},
                ["Leucine"]       = new List<string> {"UUA", "UUG"},
                ["Serine"]        = new List<string> {"UCU", "UCC", "UCA", "UCG"},
                ["Tyrosine"]      = new List<string> {"UAU", "UAC"},
                ["Cysteine"]      = new List<string> {"UGU", "UGC"},
                ["Tryptophan"]    = new List<string> {"UGG"},
                ["STOP"]          = new List<string> {"UAA", "UAG", "UGA"}
            };

        private static readonly IReadOnlyDictionary<string, string> CodonsPerProtein = CreateCodonsPerProtein();

        public static string[] Translate(string strand)
        {
            if (strand == null)
            {
                throw new ArgumentNullException(nameof(strand), "strand cannot be null.");
            }

            var proteins = strand.SplitIntoCodons().CodonsToProteins();

            return proteins.ToArray();
        }

        private static IEnumerable<string> SplitIntoCodons(this string target)
        {
            if (target.Length % 3 != 0)
            {
                throw new ArgumentException("strand should have a length multiple of 3.");
            }

            return target.Split(3);
        }

        private static IEnumerable<string> CodonsToProteins(this IEnumerable<string> target)
        {
            foreach (string s in target)
            {
                if (CodonsPerProtein.TryGetValue(s, out var protein))
                {
                    if (protein == "STOP")
                    {
                        yield break;
                    }
                    else
                    {
                        yield return protein;
                    }
                }
                else
                {
                    throw new ArgumentException($"Codon {s} is not valid.");
                }
            }
        }

        private static Dictionary<string, string> CreateCodonsPerProtein()
        {
            var result = new Dictionary<string, string>();
            
            foreach (var kvp in ProteinsPerCodons)
            {
                foreach (var codon in kvp.Value)
                {
                    result[codon] = kvp.Key;
                }
            }

            return result;
        }
    }
}