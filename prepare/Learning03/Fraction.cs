using System;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int wholeNum)
    {
        top = wholeNum;
        bottom = 1;
    }

    public Fraction(int ttop, int bbottom)
    {
        top = ttop;
        bottom = bbottom;
    }
    public string GetFractionString()
    {
        string text = $"{top}/{bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}









