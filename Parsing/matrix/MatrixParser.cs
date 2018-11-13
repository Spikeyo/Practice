

using System;
using System.Collections.Generic;
using System.Linq;

public class MatrixParser    
{
    private readonly int[][] allRows;

    public MatrixParser(string input)
    {
        var rowStrings = input.Split("\n");
        
        var rows = rowStrings.Select(RowStringToArray);

        this.allRows = rows.ToArray();
    }
    
    public int Rows => allRows.Length;
    public int Cols => allRows[0].Length;

    public int[] Row(int index)
    {
        return allRows[index].ToArray();
    }

    public int[] Column(int index)
    {
        var column = allRows.Select(x => x[index]);
        
        return column.ToArray();
    } 

    private int[] RowStringToArray(string rowString)
    {
        var digitStrings = rowString.Split(' ');

        var row = digitStrings.Select(y => Convert.ToInt32(y));
        
        return row.ToArray();
    }
}