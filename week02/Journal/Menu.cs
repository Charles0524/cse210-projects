public class Menu
{

    public static void menu()
    {
        Console.WriteLine("Hi! I am your personal journal!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int option = int.Parse(Console.ReadLine());

        while (true)
        {
                if (option == 1)
                {
                    Console.Clear();
                    Journal.randomQuestion();
                    Journal.writeEntry();
                    menu();
                    break;
                }
                if (option == 2)
                {
                    Console.Clear();
                    Journal.DisplayEntry();
                    menu();
                    break;
                }
                if (option == 3)
                {
                    Console.Clear();
                    Load.LoadEntry();
                    menu();
                    break;
                }
                if (option == 4)
                {
                    Console.Clear();
                    save.SaveEntry();
                    menu();
                    break;
                }
                if (option == 5)
                {
                    Console.Clear();
                    Console.WriteLine("You selected 'Quit'.");
                    break;
                }
                if (option < 1 || option > 5)
                {
                    Console.Clear();
                    menu();    
                    
                }
            }




        }
}