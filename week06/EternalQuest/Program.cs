using System;

/*
CREATIVITY AND EXCEEDING REQUIREMENTS

I added a Level System to the Eternal Quest program.

The user starts at Level 1 and automatically levels up
for every 1000 points earned.

When a new level is reached, the program displays
a congratulatory message.

This adds an additional gamification feature beyond
the core requirements.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine($"Level: {manager.GetLevel()}");
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine("==================================");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;

                case 2:
                    manager.ListGoals();
                    break;

                case 3:
                    manager.SaveGoals();
                    break;

                case 4:
                    manager.LoadGoals();
                    break;

                case 5:
                    manager.RecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Thank you for using Eternal Quest!");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}