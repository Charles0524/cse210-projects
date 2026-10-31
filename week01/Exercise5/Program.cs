using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(username, squaredNumber);
    }

    static void  DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = (Console.ReadLine());
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int SquaredNumber = number * number;
        return SquaredNumber;
    }
    static  void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, The square of your number is {squaredNumber}.");

    }
}