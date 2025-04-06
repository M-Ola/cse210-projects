public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing", "List positive things in your life.")
    {
        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are your achievements?",
            "What things make you happy?",
            "What are personal strengths of yours?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Listing Activity.");

        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        List<string> userResponses = GetListFromUser();
        Console.WriteLine("\nYour responses:");
        userResponses.ForEach(Console.WriteLine);

        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        var items = new List<string>();
        var startTime = DateTime.Now;

        Console.WriteLine($"You have {duration} seconds to list your responses. Go!");

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}