using System.Collections.Generic;
using System.Linq;

namespace SumOfMultiplesProject
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> divisors, int max)
        {
            var multipleCandidates = Enumerable.Range(0, max);
        
            var multiples = multipleCandidates.Where(divisors.ContainsPositiveDivisorsOf);
        
            return multiples.Sum();
        }

        private static bool ContainsPositiveDivisorsOf(this IEnumerable<int> target, int number)
        {
            return target.Where(x => x > 0).Any(x => number % x == 0);
        }
    }
}