//********************************************************
// Solution for the Hamming exercise in Exercism.io
//
// ~Spikeyo
//********************************************************

using System;

namespace HammingProject
{
    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand == null || secondStrand == null)
            {
                throw new ArgumentNullException();
            }

            if (firstStrand.Length != secondStrand.Length)
            {
                throw new ArgumentException("The strands have different lengths.");
            }

            int hammingDistance = 0;

            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}