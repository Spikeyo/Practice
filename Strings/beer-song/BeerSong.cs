//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System.Text;

namespace Songs
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < takeDown; i++)
            {
                var verse = VerseCreator.Create(startBottles--).GetWords();
                
                stringBuilder.Append(verse);
                
                stringBuilder.Append("\n");
            }

            // remove the last "\n"
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            
            return stringBuilder.ToString();
        }
    }
}