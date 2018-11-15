//****************************************************************
// Solution for the LargestSeriesProduct exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System;

namespace LargestSeriesProductProject
{
    /// <summary>
    /// Given a string of digits, calculates the largest product for a contiguous
    ///  substring of digits of a given length.
    /// </summary>
    public static class LargestSeriesProduct
    {
        public static long GetLargestProduct(string digits, int span)
        {
            if (span > digits.Length)
            {
                throw new ArgumentException("Span is greater than the length of digits.");
            }

            if (span < 0)
            {
                throw new ArgumentException("Span should not be negative.");
            }
        
            long result =  0;
            for (int i = 0; i <= digits.Length - span; i++)
            {
                var substring = digits.Substring(i, span);
            
                int product = substring.MultiplyDigitChars();
            
                if (product > result)
                {
                    result = product;
                }
            }
            return result;
        }

        private static int MultiplyDigitChars(this string substring)
        {
            int product = 1;
        
            for (int j = 0; j < substring.Length; j++)
            {
                char c = substring[j];
            
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException($"string contains an invalid char: {c}");
                }
                
                product *= (c - 48);
            }
        
            return product;
        }
    }
}