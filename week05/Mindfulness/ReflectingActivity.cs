public class ReflectingActivity : Activity
{
   
   
   
   
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflection", "Reflect on your thoughts and feelings.")
    {
        _prompts = new List<string>
        {
            "Think about a time you overcame a challenge.",
            "Recall a moment when you felt truly happy.",
            "Recall a time you felt you truly accomplished something."
       
        };

        _questions = new List<string>
        {
            "Why was this moment important to you?",
            "What did you learn from it?",
            "How can you apply this lesson in the future?"
        };
    }

    public void Run()
    {

    Console.WriteLine("Welcome to the Listing Activity.");

        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("\nAnswer these questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Console.ReadLine();
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }
}