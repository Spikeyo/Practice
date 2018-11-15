//*************************************************************
// Solution for the ProteinTranslation exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System.Collections.Generic;
using System.Linq;

namespace ProteinTranslationProject
{
    public static class StringExtension
    {
        public static IEnumerable<string> Split(this string str, int subStringLength)
        {
            var range = Enumerable.Range(0, str.Length / subStringLength);

            return range.Select(i => str.Substring(i * subStringLength, subStringLength));
        }
    }
}