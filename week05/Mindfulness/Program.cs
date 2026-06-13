using System;

// Creativity:
// Added a Gratitude Activity that extends the Activity base class.
// Users can list things they are grateful for and review their entries.
// This exceeds the core requirements by providing an additional
// mindfulness activity beyond the three required activities.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}

