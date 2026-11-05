
using System;

PromptGenerator generator = new PromptGenerator();
Journal myJournal = new Journal();

int choice = 0;

while (choice != 5)
{
    Console.WriteLine("\n===== JOURNAL MENU =====");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display journal");
    Console.WriteLine("3. Save journal");
    Console.WriteLine("4. Load journal");
    Console.WriteLine("5. Quit");

    Console.Write("Enter your choice: ");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Generate a random prompt
            string prompt = generator.GetRandomPrompt();

            Console.WriteLine(prompt);

            // Collect the user's response
            Console.Write("Your response: ");
            string response = Console.ReadLine();

            // Create a new journal entry
            Entry newEntry = new Entry(
                DateTime.Now.ToShortDateString(),
                prompt,
                response
            );

            // Add the entry to the journal
            myJournal.AddEntry(newEntry);

            Console.WriteLine("Entry added successfully!");
            break;

        case 2:
            // Display all journal entries
            myJournal.DisplayEntries();
            break;

        case 3:
            Console.Write("Enter filename to save: ");
            string saveFilename = Console.ReadLine();
            myJournal.SaveToFile(saveFilename);
            break;

        case 4:
            Console.Write("Enter filename to load: ");
            string loadFilename = Console.ReadLine();

            if (System.IO.File.Exists(loadFilename))
            {
                myJournal.LoadFromFile(loadFilename);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            break;

        case 5:
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
