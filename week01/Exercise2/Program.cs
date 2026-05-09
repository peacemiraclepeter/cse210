using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Determine letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or - sign
        int lastDigit = grade % 10;
        string sign = "";

        if (letter != "A" && letter != "F") // Only apply to B, C, D
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case: A cannot have +
        if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        // Display final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}