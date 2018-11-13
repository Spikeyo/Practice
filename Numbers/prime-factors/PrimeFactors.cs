using System.Collections.Generic;

public static class PrimeFactors
{
    public static int[] Calculate(long number)
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