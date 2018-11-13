using System.Collections.Generic;
using System.Text;

namespace RnaTranscriptorProject
{
    public static class RnaTranscriptor
    {
        private static readonly IReadOnlyDictionary<char, char> DnaNuclesToRnaNucles = new Dictionary<char, char>()
        {
            { 'G', 'C' }, 
            { 'C', 'G' }, 
            { 'T', 'A' }, 
            { 'A', 'U' }
        };

        public static string ToRna(string strand)
        {
            var rnaStringBuilder = new StringBuilder(strand.Length);

            foreach (char c in strand)
            {
                rnaStringBuilder.Append(DnaNuclesToRnaNucles[c]);
            }

            return rnaStringBuilder.ToString();
        }
    }
}