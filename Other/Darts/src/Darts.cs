//*************************************************************
// Solution for the Darts exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace DartsProject
{
    public static class Darts
    {
        private static IReadOnlyList<DartBoardRing> Rings { get; } = new List<DartBoardRing>
        {
            new DartBoardRing("Outside", int.MaxValue, 0),
            new DartBoardRing("Outer Ring", 10, 1),
            new DartBoardRing("Middle Ring", 5, 5),
            new DartBoardRing("Bullseye", 1, 10)
        };

        public static int CalculateScore(double x, double y) => FindHitRing(x, y).Points;

        public static DartBoardRing FindHitRing(double x, double y)
        {
            double distanceToCenter = Math.Sqrt(x * x + y * y);
        
            return Rings.Last(r => r.MaxRadius >= distanceToCenter);
        }
    }
}



