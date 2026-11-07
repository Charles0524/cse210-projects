 public class Journal


{
    public static string randomQuestion()
    {
        string[] randomQuestions = {
            "What is the highlight of your day?",
            "What are you grateful for today?",
            "What is one thing you learned today?",
            "Who is the person that made a positive impact on your day?",
            "What did you pray for this morning?",
            "What is one thing you can do to make tomorrow better?",
            "What is one thing you remember from the past that made you happy?",

        };
        Random random = new Random();
        int index = random.Next(0, randomQuestions.Length);
        string question = randomQuestions[index];
        return question;    
    }
    
    public static void writeEntry()
    {
        string question = randomQuestion();
        Console.WriteLine($"Prompt: {question}");
        string journalEntry = Console.ReadLine();
        savetoFile(question, journalEntry);
    }
    public static void savetoFile(string question ,string journalEntry, string filePath = "journal.txt")
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
                writer.WriteLine($"{DateTime.Now}: Prompt: {question} , {journalEntry}");
            }
        }
        public static void DisplayEntry()
        {
            string filePath = "journal.txt";
            if (File.Exists(filePath))
            {
                string[] entries = File.ReadAllLines(filePath);
                Console.WriteLine("Your journal entries:");
                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("No journal entries found.");
            }
        }
        
}

       
       
       
      
        
    


    


