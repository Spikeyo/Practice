using System;
using System.Collections.Generic;
using System.Linq;

public class Matrix    
{
    private readonly int[][] allRows;

    public Matrix(string input)
    {
        var rowStrings = input.Split("\n");
        
        var rows = rowStrings.Select(RowStringtoArray);

        this.allRows = rows.ToArray();
    }
    
    public int Rows => allRows.Length;
    public int Cols => allRows[0].Length;

    public int[] Row(int index) => allRows[index].ToArray();

    public int[] Column(int index)
    {
        var column = allRows.Select(x => x[index]);
        
        return column.ToArray();
    } 

    private int[] RowStringtoArray(string rowString)
    {
        var digitStrings = rowString.Split(' ');

        var row = digitStrings.Select(y => Convert.ToInt32(y));
        
        return row.ToArray();
    }
}