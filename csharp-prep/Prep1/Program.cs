/*
C# Practice Prep for Loops, Conditionals, Variables, and Data Types
!!!Grade Calculator!!!
Completed Strech Challenge
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        string sign;
        string letter;
        Console.Write("What is your final score for the class? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        int lastDigit = grade % 10;

        //if loop for letter grade
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

         //If loop to determine sign
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        

        //If loop for sign exceptions
        if (letter == "A" && sign == "+")
        {
            sign = ""; //No A+
        }
        if (letter == "F")
        {
            sign = ""; //No F+ or F-
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        
        
        //If loop pass of fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass the class, better luck next time!");
        }


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
            //1st attempt
            /*
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
            */

    }
}