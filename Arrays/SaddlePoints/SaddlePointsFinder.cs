//****************************************************************
// Solution for the exercise SaddlePoints in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System.Collections.Generic;

namespace SaddlePoints
{
    /// <summary>
    /// Finds saddle points in a matrix. A saddle point is an element that
    ///  is greater than or equal to every other element in its row and,
    ///  at the same time, less than or equal to every other element in
    ///  its column.
    /// </summary>
    public class SaddlePointsFinder
    {
        private readonly int[,] matrix;

        public SaddlePointsFinder(int[,] values) => matrix = values;

        public IEnumerable<(int, int)> Find()
        {
            List<(int, int)> saddlePoints = new List<(int, int)>();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix.HasSaddlePointAt((i, j))) saddlePoints.Add((i, j));

            return saddlePoints;
        }
    }
}