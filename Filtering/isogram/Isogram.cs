//********************************************************
// Solution for the Isogram exercise in Exercism.io
//
// ~Spikeyo
//********************************************************

using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            var upperCaseLetters = word.Where(char.IsLetter).Select(char.ToUpper);

            var hasRepeatedLetters = upperCaseLetters.TakeRepeated().Any();
            
            return !hasRepeatedLetters;
        }
    
        public static IEnumerable<T> TakeRepeated<T>(this IEnumerable<T> target) where T : struct 
        {
            var previousItems = new List<T>();

            foreach (var item in target)
            {
                if (previousItems.Contains(item))
                {
                    yield return item;
                }
                else
                {
                    previousItems.Add(item);
                }
            }
        }
    }
}
