using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = promptUserName();
        int favouriteNumber = promptFavoriteNumber();
        int squaredNumber = squareNumber(favouriteNumber);
       string results= DisplayResults(userName, favouriteNumber, squaredNumber);
        Console.WriteLine(results);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string promptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }
    static int promptFavoriteNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int favouriteNumber = int.Parse(Console.ReadLine());
        return favouriteNumber;
    }
    static int squareNumber(int number)
    {
        return number * number;
    }
    static string DisplayResults(string userName, int favouriteNumber, int squaredNumber)
    {
        return $"{userName}, the square of your favorite number is {squaredNumber}.";
    }
}