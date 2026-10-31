using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! Welcome to the guessing game.");
       
            Console.Write("Please enter a number between 1 and 101:");
            int magicNumber = int.Parse(Console.ReadLine());
            while (magicNumber < 1 || magicNumber > 101)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 101.");
                Console.Write("Please enter a number between 1 and 101:");
                magicNumber = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            int guess = 0;
            int attempts = 0;
            while (guess != magicNumber )
            {
                Console.Write("Please enter  your guess between 1 and 101:");
                guess = int.Parse(Console.ReadLine());
                attempts++;
                Console.Clear();
                if (guess < magicNumber)
            {
                Console.WriteLine("Higher! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower! Try again.");
            }
            }
            Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
            Console.WriteLine("Would you like to play again? (yes/no)");
            string playAgain = Console.ReadLine();

            while (playAgain.ToLower() != "yes" && playAgain.ToLower() != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                Console.WriteLine("Would you like to play again? (yes/no)");
                playAgain = Console.ReadLine();
            }
    

            if (playAgain.ToLower() == "yes")
            {
                Console.Clear();
                Main(args);
            }
            else if (playAgain.ToLower() == "no")
            {
                Console.WriteLine("Thank you for playing! Goodbye.");
                return;
            }

        }
    

    }
