public class Fractions
{
    private int top;
    private int bottom;
    public Fractions()
    {
        top = 1;
        bottom = 1;
    }
    public Fractions(int numerator)
    {
        top = numerator;
        bottom = 1;
    }
    public Fractions(int numerator, int denominator)
    {
        top = numerator;
        bottom = denominator;
    }
    public int GetTop()
    {
        return top;
    }
    public int GetBottom()
    {
        return bottom;
    }
    public void SetTop(int numerator)
    {
        top = numerator;
    }
    public void SetBottom(int denominator)
    {
        bottom = denominator;
    }
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}