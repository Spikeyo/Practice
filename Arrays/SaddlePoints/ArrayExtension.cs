public static class ArrayExtension
{
    /// <summary>
    /// Finds out whether the extended array has a saddle point at the position.
    /// </summary>
    /// <param name="position"> The position of the potential saddle point. 
    ///  Item1 represents the row index, Item2 represents the column index. </param>
    public static bool HasSaddlePointAt(this int[,] matrix, (int, int) position)
    {
        int saddleValue = matrix[position.Item1, position.Item2];

        //loops through row, return false if any other element is greater
        for (int i = 0; i < matrix.GetLength(1); i++)
            if (matrix[position.Item1, i] > saddleValue) return false;

        //loops through column, return false if any other element is smaller
        for (int i = 0; i < matrix.GetLength(0); i++)
            if (matrix[i, position.Item2] < saddleValue) return false;

        return true;
    }
}
