//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

namespace Songs.Verses
{
    public class SingleBeerVerse : BeerVerse
    {
        public SingleBeerVerse()
            : base
            (
                topBottleWords: "1 bottle",

                bottomBottleWords: "no more bottles",

                startingBottomWords: "Take it down and pass it around"
            )
        {
            
        }
    }
}