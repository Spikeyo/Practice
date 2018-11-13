//*************************************************************
// Solution for the RobotSimulator exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

public struct Coordinates
{
    public Coordinates(int x, int y) => (X, Y) = (x, y);

    public int X { get; }
    public int Y { get; }
    
    public static Coordinates operator +(Coordinates first, Coordinates second)
    { 
        return new Coordinates(first.X + second.X, 
                               first.Y + second.Y);
    } 
}