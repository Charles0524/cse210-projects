using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            letter += "+";

        }
        else if (lastDigit <= 3)
        {
            letter += "-";
        }

        if (letter == "A+")
        {
            letter = "A";
        }
        if (letter == "F+")
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }

            

    }
}