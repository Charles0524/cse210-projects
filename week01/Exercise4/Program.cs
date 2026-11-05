using System;
using System.Reflection.Metadata.Ecma335;

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
            List <int> numbersWithoutZero = new List<int>(numbers);
            numbersWithoutZero.RemoveAll(n => n == 0);
            Console.WriteLine("The numbers you entered are:");
            foreach (int number in numbersWithoutZero)
            {
                Console.WriteLine(number);
            }

            int sum = 0;
            foreach (int number in numbersWithoutZero)
            {
                sum += number;
            }
            int average = sum / numbersWithoutZero.Count;
            numbersWithoutZero.Sort();

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
            
            foreach (int number in numbersWithoutZero)
            {
                Console.WriteLine($"The sorted numbers are: {number}");
            }
            break;
            }
        }
    }