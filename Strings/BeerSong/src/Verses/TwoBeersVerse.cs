//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

namespace BeerSongProject.Verses
{
    public class TwoBeersVerse : BeerVerse
    {
        public TwoBeersVerse()
            : base
            (
                topBottleWords: "2 bottles",

                bottomBottleWords: "1 bottle",

                startingBottomWords: "Take one down and pass it around"
            )
        {
            
        }
    }
}