public class Load
{
public static void LoadEntry()
    {
        Console.WriteLine("Please enter the file name:");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            string[] entries = File.ReadAllLines(filePath);
            Console.WriteLine("Your journal entries:");
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }
            File.Copy(filePath, "journal.txt", true);
            File.Delete(filePath);
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path and try again.");
            Menu.menu();
        }
    }
}