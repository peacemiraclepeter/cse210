using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. Added more than 5 prompts.
        // 2. Added a motivational welcome message.
        // 3. Added confirmation messages after saving/loading.
        // 4. Added error handling for missing files.

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}