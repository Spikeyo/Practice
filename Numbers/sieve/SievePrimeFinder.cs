using System;
using System.Collections.Generic;
using System.Linq;

public static class SievePrimeFinder
{
    public static int[] Find(int limit)
    {
        if (limit < 2)
        {
            throw new ArgumentOutOfRangeException("limit should be greater than 1.");
        }

        var rangeList = Enumerable.Range(2, limit - 1).ToList();

        for (int i = 0; i < rangeList.Count; i++)
        {
            rangeList.RemoveMultiplesOf(rangeList[i], limit);
        }

        return rangeList.ToArray();
    }
    
    private static void RemoveMultiplesOf(this List<int> target, int toMultiply, int limit)
    {
        for (var i = 2; i * toMultiply <= limit; i++)
        {
            target.Remove(i * toMultiply);
        }
    }
}