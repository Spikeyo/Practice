using System.Collections.Generic;

namespace PrimeFactorsProject
{
    public class PrimeFactorIterator
    {
        public IEnumerable<int> Find(long number)
        {
            int factor = 2;
        
            while (number > 1)
            {
                while (number % factor != 0)
                {
                    factor++;
                }

                yield return factor;
            
                number /= factor;
            }
        }
    }
}