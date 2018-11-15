using System;

namespace BinarySearchProject
{
    /// <summary>
    /// A classic binary search with recursion
    /// inspired by hayashida katsutoshi's solution
    /// </summary>
    public static class RecursiveBinarySearch
    {
        public static int FindIndex(int[] input, int targetValue)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null.");
            }
            
            return RecursiveSearch(input, targetValue, 0, input.Length-1);
        }

        private static int RecursiveSearch(int[] input, int targetValue, 
                                           int lowLimit, int highLimit)
        {
            if (lowLimit > highLimit)
            {
                return -1;
            }
        
            int index = lowLimit + (highLimit - lowLimit) / 2;

            if (input[index] > targetValue)
            {
                return RecursiveSearch(input, targetValue, lowLimit, index - 1);
            }

            if (input[index] < targetValue)
            {
                return RecursiveSearch(input, targetValue, index + 1, highLimit);
            }
            
            return index;
        }
    }
}