using System.Collections.Generic;

namespace PangramProject
{
    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            input = input.ToLower();
        
            var uniqueLetters = new List<char>();

            foreach (char letter in input)
            {
                // checks if the character is a lower case letter and 
                //  is not contained in uniqueLetters.
                // Cannot use char.IsLetter here because it validates special letters
                if (letter >= 097 
                    && letter <= 122
                    && !uniqueLetters.Contains(letter))
                {
                    uniqueLetters.Add(letter);
                }
            }

            return uniqueLetters.Count == 26;
        }
    }
}
