using System;

namespace BinarySearchProject
{
    /// <summary>
    /// A classic binary search with a loop
    /// </summary>
    public static class LoopBinarySearch
    {
        public static int FindIndex(int[] input, int targetValue)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null.");
            }

            (int Min, int Max) searchLimits = (0, input.Length - 1);
        
            while (searchLimits.Min <= searchLimits.Max)
            {
                int index = ((searchLimits.Max - searchLimits.Min) / 2) + searchLimits.Min;

                if (input[index] == targetValue)
                {
                    return index;
                }

                if (targetValue > input[index])
                {
                    searchLimits.Min = index + 1;
                }
                else
                {
                    searchLimits.Max = index;
                }
            }

            return -1;
        }
    }
}