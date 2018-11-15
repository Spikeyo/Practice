//****************************************************************
// Solution for the BeerSong polymorphism exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System;
using BeerSongProject.Verses;

namespace BeerSongProject
{
    public static class VerseCreator
    {
        public static BeerVerse Create(int numBottles)
        {
            if (numBottles < 0 || numBottles > 99)
            {
                throw new ArgumentOutOfRangeException();
            }

            switch (numBottles)
            {
                case 0: return new NoBeerVerse();
                case 1: return new SingleBeerVerse();
                case 2: return new TwoBeersVerse();
                default: return new MoreThanTwoBeersVerse(numBottles);
            }
        }
    }
}