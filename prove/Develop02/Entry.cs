using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void generateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    /*public void displayEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }
    */

    public void GeneratePrompt()
    {
        List<string> _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void getResponse()
    {
        Console.WriteLine("Please leave a response. ");
        _response = Console.ReadLine();
    }

}