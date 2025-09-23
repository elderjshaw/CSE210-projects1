using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Prep1 World!");

        string firstName = "Bob";

        Console.WriteLine($"Hello, {firstName}!");

        Console.Write("What is your favorite color?");
        string favoriteColor = Console.ReadLine();

        Console.WriteLine($"Your favorite color is {favoriteColor}!");

        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"You are {age} years old.");
        */
        /*
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}! ");
        */
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}! ");
    }
}