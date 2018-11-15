using System;
using System.Linq;

namespace PerfectNumbersProject
{
    public static class PerfectNumbers
    {
        public static NumberType Classify(int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException();

            int sumOfFactors = SumOfFactors(number);
        
            if (number < sumOfFactors) return NumberType.Abundant;
            if (number > sumOfFactors) return NumberType.Deficient;
        
            return NumberType.Perfect;
        }

        public static int SumOfFactors(int i)
        {
            var factors = Enumerable.Range(1, i - 1).Where(x => i % x == 0);
        
            return factors.Sum();  
        }
    }
}
