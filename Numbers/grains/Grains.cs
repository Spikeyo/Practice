//****************************************************************
// Solution for the Grains exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System;

namespace Grains
{
    public static class Grains
    {
        public static ulong Square(int n)
        {
            if (n < 1 || n > 64)
            {
                throw new ArgumentOutOfRangeException();
            }

            return (ulong)Math.Pow(2, n - 1);
        }

        public static ulong Total()
        {
            ulong total = 0UL;

            for (int i = 1; i <= 64; i++)
            {
                total += Square(i);
            }

            return total;
        }
    }
}