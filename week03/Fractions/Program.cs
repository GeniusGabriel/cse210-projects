using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(5);
        Fractions fraction3 = new Fractions(3, 4);

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalValue());
    }
   
}