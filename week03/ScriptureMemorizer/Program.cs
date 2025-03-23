using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Example reference with a range of verses
        Reference reference = new Reference("John", 3, 16, 18);
        Scripture scripture = new(reference, "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word (or type 'quit' to exit)");

       string input=     Console.ReadLine();
       if(input.Equals("quit", StringComparison.CurrentCultureIgnoreCase)) break;

            scripture.HideRandomWords();
            
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden!");
    }


}
