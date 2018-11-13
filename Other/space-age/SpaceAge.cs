//*************************************************************
// Solution for the SpaceAge mini-exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

public class SpaceAge
{
    public const double SecondsPerYear = 60 * 60 * 24 * 365.25;
    
    public SpaceAge(long seconds)
    {
        Seconds = seconds;
    }

    public long Seconds { get; set; }

    public double OnEarth()
    {
        return Seconds / SecondsPerYear;
    }

    public double OnMercury()
    {
        return Seconds / (SecondsPerYear * 0.2408467);
    }

    public double OnVenus()
    {
        return Seconds / (SecondsPerYear * 0.61519726);
    }

    public double OnMars()
    {
        return Seconds / (SecondsPerYear * 1.8808158);
    }

    public double OnJupiter()
    {
        return Seconds / (SecondsPerYear * 11.862615);
    }

    public double OnSaturn()
    {
        return Seconds / (SecondsPerYear * 29.447498);
    }

    public double OnUranus()
    {
        return Seconds / (SecondsPerYear * 84.016846);
    }

    public double OnNeptune()
    {
        return Seconds / (SecondsPerYear * 164.79132);
    }
}