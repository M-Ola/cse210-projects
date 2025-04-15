using System;
// Author Monsuru Oladipo. CSE 210
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Console.WriteLine("Exercise Tracking App");

        // Creating instances of each activity
        Activity running = new Running("14 Apr 2025", 30, 5.0); // 5 km
        Activity cycling = new Cycling("14 Apr 2025", 40, 20.0); // 20 kph
        Activity swimming = new Swimming("14 Apr 2025", 25, 30); // 30 laps

        // Adding activities to a list
        List<Activity> _ctivities = new List<Activity> { running, cycling, swimming };

        // Displaying summaries
        Console.WriteLine("\nActivity Summaries:");
        foreach (Activity activity in _ctivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }


}
