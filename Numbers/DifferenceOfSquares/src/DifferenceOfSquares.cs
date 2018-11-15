using System;
using System.Linq;

namespace DifferenceOfSquaresProject
{
    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            var sum = Enumerable.Range(1, max).Sum();
        
            return (int)Math.Pow(sum, 2);
        }

        public static int CalculateSumOfSquares(int max)
        {
            var range = Enumerable.Range(1, max);

            var rangeOfSquares = range.Select(x => (int)Math.Pow(x, 2));
        
            return rangeOfSquares.Sum();
        }

        public static int CalculateDifferenceOfSquares(int max)
            => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}