using System;

namespace BinarySearchProject
{
    /// <summary>
    /// A classic binary search that uses a loop instead of recursion.
    /// </summary>
    public static class BinarySearch
    {
        public static int FindIndex(int[] input, int targetValue)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null.");
            }

            (int Min, int Max) searchLimits = (0, input.Length);
            int index = FindLowerMiddleIndex(input);
        
            while (input[index] != targetValue)
            {
                if (index == 0 || index == input.Length - 1
                               || searchLimits.Max == searchLimits.Min)
                {
                    return -1;
                }

                if (targetValue > input[index])
                {
                    searchLimits.Min = index + 1;
                    index = FindLowerMiddleInt(index + 1, searchLimits.Max);
                }
                else
                {
                    searchLimits.Max = index;
                    index = FindLowerMiddleInt(searchLimits.Min, index);
                }
            }

            return index;
        }
    
        private static int FindLowerMiddleIndex(int[] input)
        {
            return FindLowerMiddleInt(0, input.Length);
        }

        /// <summary>
        /// Calculates the truncated half of the difference between the two values.
        /// </summary>
        private static int FindLowerMiddleInt(int lowValue, int highValue)
        {
            return ((highValue - lowValue) / 2) + lowValue;
        }
    }
}