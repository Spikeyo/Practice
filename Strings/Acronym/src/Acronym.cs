using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AcronymProject
{
    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            var filteredPhrase = phrase.ReplaceNonLettersWith(" ");
        
            var words = filteredPhrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
            var stringBuilder = new StringBuilder();
        
            foreach (var word in words)
            {
                stringBuilder.Append(char.ToUpper(word[0]));
            }

            return stringBuilder.ToString();
        }

        private static string ReplaceNonLettersWith(this string target, string replacement)
        {
            Regex regex = new Regex("[^a-zA-Z]");
        
            return regex.Replace(target, replacement);
        }
    }
}