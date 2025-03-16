public class Journal
{

   


    public  List<Entry> entries = new List<Entry>();
  

    public Journal()
    {
     
     
       
    }

    // Add a new journal entry
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
        }
        else
        {
            foreach (var entry in entries)
            {
                entry.Display();
            }
        }
    }

    

    public void LoadEntriesFromFile()
    {
        Console.Write("Enter the file path to load entries (e.g., journal.txt): ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("[") && line.Contains("]")) // Timestamp line
                    {
                        DateTime timestamp = DateTime.Parse(line.Trim('[', ']'));
                        string promptLine = reader.ReadLine()?.Substring(8); // Skip "Prompt: "
                        string contentLine = reader.ReadLine()?.Substring(7); // Skip "Entry: "

                        entries.Add(new Entry(promptLine, contentLine) { Date = timestamp });
                        reader.ReadLine(); // Skip the blank line
                    }
                }
            }
            Console.WriteLine("Entries loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path and try again.");
        }
    }



    public void SaveEntriesToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"[{entry.Date}]");
                writer.WriteLine($"Prompt: {entry._prompt}");
                writer.WriteLine($"Entry: {entry._response}");
                writer.WriteLine(); // Blank line between entries
            }
        }
        Console.WriteLine("Entries saved to file.");
    }




}
