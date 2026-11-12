using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction function1 = new Fraction();
        Console.WriteLine(function1.GetFractionString());
        Console.WriteLine(function1.GetDecimalValue());

        Fraction function2 = new Fraction(5);
        Console.WriteLine(function2.GetFractionString());
        Console.WriteLine(function2.GetDecimalValue());

        Fraction function3 = new Fraction(3, 4);
        Console.WriteLine(function3.GetFractionString());
        Console.WriteLine(function3.GetDecimalValue());

        Fraction function4 = new Fraction(2, 5);
        Console.WriteLine(function4.GetFractionString());
        Console.WriteLine(function4.GetDecimalValue());

    }
}