//*************************************************************
// Solution for the Etl mini-exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System.Collections.Generic;

public static class ScrabbleLetterETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newDic = new Dictionary<string, int>();

        foreach (var kvp in old)
        {
            foreach (string value in kvp.Value)
            {
                newDic[value.ToLower()] = kvp.Key;
            }
        }

        return newDic;
    }           
}