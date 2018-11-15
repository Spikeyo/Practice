using System.Collections.Generic;

namespace PrimeFactorsProject
{
    public static class PrimeFactorFinder
    {
        public static int[] Find(long number)
        {
            var factors = new List<int>();
        
            int factor = 2;
        
            while (number > 1)
            {
                while (number % factor != 0)
                {
                    factor++;
                }
            
                factors.Add(factor);
            
                number /= factor;
            }
            return factors.ToArray();
        }
    }
}