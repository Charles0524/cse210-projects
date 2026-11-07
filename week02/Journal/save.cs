public class save
{


 public static void SaveEntry()
    {
        Console.WriteLine("Please enter your filename (without extension and space):");
        string fileName = Console.ReadLine();
        string filePath = $"{fileName}.txt";
        if (File.Exists(filePath))
        {
            Console.WriteLine("A file with that name already exists. Please choose a different name.");
            SaveEntry();
        }
        else
        {
            string filename2 = $"{fileName}.txt";
            File.Move("journal.txt", filename2);
            Console.WriteLine($"Your journal entries have been saved to {filename2}");
        }

        
            }
}