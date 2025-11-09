using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        StartMessage();
        Random rand = new Random();

        // Choose a random prompt
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} --- ");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); 
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items! Great job! ");
        EndMessage();
    }
}
