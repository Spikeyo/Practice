//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

namespace BeerSongProject.Verses
{
    public abstract class BeerVerse
    {
        private readonly string words;
        
        protected BeerVerse(string topBottleWords,
                            string bottomBottleWords,
                            string startingBottomWords)
        {
            words = $"{topBottleWords} of beer on the wall, "      +
                    $"{topBottleWords.ToLower()} of beer.\n"       +
                    $"{startingBottomWords}, {bottomBottleWords} " + 
                     "of beer on the wall.\n";
        }

        public string GetWords()
        {
            return words;
        }
    }
}