using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int typed = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        numbers.Add(typed);

        while (typed != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            typed = int.Parse(Console.ReadLine());
            numbers.Add(typed);
            }
        while (typed == 0)
            {
            Console.WriteLine("The numbers you entered are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            int average = sum / numbers.Count;
            numbers.Sort();

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
            
            foreach (int number in numbers)
            {
                Console.WriteLine($"The sorted numbers are: {number}");
            }
            break;
            }
        }
    }
