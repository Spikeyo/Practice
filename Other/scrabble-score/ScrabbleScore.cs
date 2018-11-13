//*************************************************************
// Solution for the ScrabbleScore exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System.Linq;
using System.Collections.Generic;

public static class ScrabbleScore
{
    private static IReadOnlyDictionary<int, IReadOnlyList<char>> CharsPerPoints { get; }
                      = new Dictionary<int, IReadOnlyList<char>>()
    {
        {1, new List<char> {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}},
        {2, new List<char> {'D', 'G'}},
        {3, new List<char> {'B', 'C', 'M', 'P'}},
        {4, new List<char> {'F', 'H', 'V', 'W', 'Y'}},
        {5, new List<char> {'K'}},
        {8, new List<char> {'J', 'X'}},
        {10, new List<char> {'Q', 'Z'}}
    };

    private static IReadOnlyDictionary<char, int> PointsPerChars { get; } = ParseCharsPerPoints();

    public static int Score(string input)
    {
        var upperCaseString = (input ?? string.Empty).ToUpper();
        
        return upperCaseString.Sum(x => PointsPerChars[x]);
    }
       
    private static IReadOnlyDictionary<char, int> ParseCharsPerPoints()
    {
        var dic = new Dictionary<char, int>();

        foreach (var keyValuePair in CharsPerPoints)
        {
            foreach (char item in CharsPerPoints[keyValuePair.Key])
            {
                dic[item] = keyValuePair.Key;
            }
        }

        return dic;
    }

}