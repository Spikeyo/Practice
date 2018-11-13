//*************************************************************
// Solution for the RobotSimulator exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;
using System.Collections.Generic;

public class RobotSimulator
{
    private readonly IReadOnlyDictionary<char, Action> actionsPerChar;
    
    private readonly IReadOnlyDictionary<Direction, Coordinates> movementsPerDirection 
                        = new Dictionary<Direction, Coordinates>
    {
        [Direction.North] = new Coordinates( 0,  1),    
        [Direction.East]  = new Coordinates( 1,  0),    
        [Direction.West]  = new Coordinates(-1,  0),    
        [Direction.South] = new Coordinates( 0, -1)    
    };

    public Direction CurrentDirection { get; private set; }
    public Coordinates CurrentCoordinates { get; private set; }
    
    public RobotSimulator(Direction startDirection, Coordinates startCoordinate)
    {
        (CurrentDirection, CurrentCoordinates) = (startDirection, startCoordinate);
        
        actionsPerChar = new Dictionary<char, Action>
        {
            ['A'] = Advance,
            ['L'] = TurnLeft,
            ['R'] = TurnRight
        };
    }

    public void TurnRight()
    {
        CurrentDirection = (CurrentDirection == Direction.West 
                            ? Direction.North 
                            : CurrentDirection+1);
    }

    public void TurnLeft()
    {
        CurrentDirection = (CurrentDirection == Direction.North 
                            ? Direction.West 
                            : CurrentDirection-1);
    }

    public void Advance()
    {
        CurrentCoordinates += movementsPerDirection[CurrentDirection];
    }

    public void Simulate(string instructions)
    {
        foreach (char i in instructions)
        {
            if (actionsPerChar.TryGetValue(i, out var action))
            {
                action();
            }
            else
            {
                throw new ArgumentException(nameof(instructions),
                                            $"instructions contains an invalid character: {i}");
            }
        }
    }
}
