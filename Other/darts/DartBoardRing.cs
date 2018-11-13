//*************************************************************
// Solution for the Darts exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;

public class DartBoardRing
{
    public string Name { get; } 
    public int MaxRadius { get; } 
    public int Points { get; } 
    
    public DartBoardRing(string name, int maxRadius, int points)
    {
        Validate(name, maxRadius, points);
        Name = name;
        MaxRadius = maxRadius;
        Points = points;
    }

    private void Validate(string name, int maxRadius, int points)
    {
        if (maxRadius < 0 || points < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (name == null)
        {
            throw new ArgumentNullException(nameof(name), "name cannot be null.");
        }
    }
}