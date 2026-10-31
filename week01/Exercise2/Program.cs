using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        Console.WriteLine("What is your grade percentage?");
        int gradeInput = int.Parse(Console.ReadLine());

        // 1. Declare a variable to store the letter grade
        string letter = "";

        // 2. Assign the letter value inside each block instead of printing
        if (gradeInput >= 90)
        {
            letter = "A";
        }
        else if (gradeInput >= 80)
        {
            letter = "B";
        }
        else if (gradeInput >= 70)
        {
            letter = "C";
        }
        else if (gradeInput >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 3. Print the letter grade once at the end
        Console.WriteLine($"Your grade is {letter}");

        // 4. Core Requirement 2: Pass/Fail check
        if (gradeInput >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Stay encouraged and work hard for next time!");
        }
    }
}