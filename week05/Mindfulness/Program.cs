using System;

//Author Monsuru Oladipo. cse 210

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit\n");

        var breathingActivity = new BreathingActivity();
        var listingActivity = new ListingActivity();
        var reflectingActivity = new ReflectingActivity();

        bool running = true;
        while (running)
        {
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                case 4:
                    running = false;
                    Console.WriteLine("Exiting program. Stay mindful!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }




}
