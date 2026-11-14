using System;
// Creativity: I expanded the program to include a library of
// multiple scriptures. Each time the program runs, it randomly
// selects one scripture for the user to memorize.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture[] scriptureLibrary = new Scripture[]
{
    new Scripture(
        new Reference("Hebrews", 1, 1),
        "In the past God spoke to our ancestors through the prophets at many times and in various ways"),

    new Scripture(
        new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all your heart and lean not on your own understanding"),

    new Scripture(
        new Reference("Philippians", 4, 13),
        "I can do all things through Christ who strengthens me")
};
        Random random = new Random();

        int randomIndex = random.Next(0, scriptureLibrary.Length);

        Scripture scripture = scriptureLibrary[randomIndex];
        Console.Clear();


        // Creativity: Randomly selects only words that are
        // still visible, preventing repeated hiding.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
            scripture.HideRandomWords(3);
            Console.Clear();

        }
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Congratulations! You have memorized the scripture!");
    }
}