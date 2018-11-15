using System;

namespace QueenAttackProject
{
    public static class QueenAttack
    {
        public static bool CanAttack(Queen white, Queen black)
        {
            return white.Row == black.Row
                   || white.Column == black.Column
                   || DoQueensShareDiagonal(white, black);
        }

        public static Queen Create(int row, int column)
        {
            if (row < 0 || column < 0 || row > 7 || column > 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Queen(row, column);
        }

        private static bool DoQueensShareDiagonal(Queen first, Queen second)
        {
            int xDistance = Math.Abs(first.Column - second.Column);
            int yDistance = Math.Abs(first.Row - second.Row);

            return xDistance == yDistance;
        }
    }
}