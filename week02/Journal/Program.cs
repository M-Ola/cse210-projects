using System;

// Author: Monsuru Oladipo CSE 210
// Week 02

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your Journal App!");

        var promptGenerator = new PromptGenerator();
        bool exit = false;


        while (!exit)
        {


            ShowMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the file path to save entries (e.g., journal.txt): ");
                    string filePath = Console.ReadLine();
                    journal.SaveEntriesToFile(filePath);
                    break;

                case "4":
                    journal.LoadEntriesFromFile();
                    break;

                case "5":

                    Console.WriteLine("Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void ShowMenu()
    {

        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. View Entries");
        Console.WriteLine("3. save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Exit");

        Console.WriteLine("Choose an option: ");


    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        Console.Clear();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("\nYour response: ");
        string response = Console.ReadLine();

        var newEntry = new Entry(prompt, response);
        journal.AddEntry(newEntry);
    }
}








   
   
   
   
    









