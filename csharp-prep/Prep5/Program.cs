using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, squared, birthYear);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the C# Prep5 program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Whats your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is: {square} ");

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, you will turn {2025 - birthYear} this year. ");
    }
}