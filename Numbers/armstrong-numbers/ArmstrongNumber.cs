using System;

namespace ArmstrongNumbers
{
    public static class ArmstrongNumber
    {
        public static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            var numberString = number.ToString();
        
            foreach (char c in numberString)
            {
                sum += (int)Math.Pow(c - 48, numberString.Length);
            }
            
            return sum == number;
        }    
    }
}