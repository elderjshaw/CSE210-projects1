using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need. ",
        "Think of a time when you did something truly selfless. "
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times?",
        "What did you learn about yourself?",
        "How can you apply this in the future?"
    };

    public ReflectionActivity()
        : base("Reflection",
        "This short activity will help you reflect on times in your life when you have shown strength and resilience. ")
    {
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();

        // Choose a random prompt for the user
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions: ");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question} ");
            ShowSpinner(5); // pause to reflect, make shorter if neccesary
        }

        EndMessage();
    }
}
