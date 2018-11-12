using System;

public static class CollatzConjecture
{
    public static int FindNumSteps(int number)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        int numSteps = 0;
        while (number != 1)
        {
            numSteps++;
            number = ApplyCollatzOperation(number);
        }
        
        return numSteps;
    }

    private static int ApplyCollatzOperation(int number)
    {
        if (number % 2 == 0)
        {
            return number / 2;
        }
        else
        {
            return number * 3 + 1;
        }
    }
}