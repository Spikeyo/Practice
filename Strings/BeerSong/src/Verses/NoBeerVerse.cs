//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

namespace BeerSongProject.Verses
{
    public class NoBeerVerse : BeerVerse
    {
        public NoBeerVerse()
            : base
            (
                topBottleWords: "No more bottles",

                bottomBottleWords: "99 bottles",

                startingBottomWords: "Go to the store and buy some more"
            )
        {
            
        }
    }
}