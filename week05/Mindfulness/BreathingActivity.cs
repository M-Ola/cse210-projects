public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing ", "Focus on your breathing. Inhale and exhale slowly.") { }

    public void Run()
    {

        Console.WriteLine("Welcome to the Breathing Activity.");

        DisplayStartingMessage();

        for (int i = 0; i < duration / 4; i++) // 4 seconds per inhale/exhale cycle
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000);
        }

        DisplayEndingMessage();
    }
}