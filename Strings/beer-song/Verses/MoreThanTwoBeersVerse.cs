//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

namespace BeerSongProject.Verses
{
    public class MoreThanTwoBeersVerse : BeerVerse
    {
        public MoreThanTwoBeersVerse(int numBeers) 
            : base 
            (
                topBottleWords: $"{numBeers.ToString()} bottles",
                                        
                bottomBottleWords: $"{(numBeers - 1).ToString()} bottles",
                                        
                startingBottomWords: "Take one down and pass it around"
            )
        {
            
        }
    }
}