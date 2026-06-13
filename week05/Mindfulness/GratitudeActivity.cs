using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base(
            "Gratitude",
            "This activity will help you focus on the blessings in your life by listing things you are grateful for.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Think about the blessings in your life.");
        Console.WriteLine("List as many things as you are grateful for as you can.");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> gratitudeItems = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                gratitudeItems.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {gratitudeItems.Count} things you are grateful for!");

        Console.WriteLine();
        Console.WriteLine("Your Gratitude List:");

        foreach (string item in gratitudeItems)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
    }
}

