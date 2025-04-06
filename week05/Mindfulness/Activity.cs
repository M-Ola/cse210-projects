public class Activity
{
    private string _name;
    private string _description;
    protected int duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting {_name}");
        Console.WriteLine(_description);

        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int inputDuration) && inputDuration > 0)
        {
            duration = inputDuration;
        }
        else
        {
            Console.WriteLine("Invalid input. Default duration of 30 seconds will be used.");
            duration = 30;
        }

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You’ve completed the activity.");
        Console.WriteLine($"You just finished {_name}, which lasted {duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine("Thank you for participating!");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 5 ; i++) // Spinner cycles
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b/");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.WriteLine($"{i}...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}