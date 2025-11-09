using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity! ");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready... ");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job! ");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {_name} Activity for {_duration} seconds. ");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);        
            Console.Write("\b \b");      // erase spinner
            i = (i + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);       // 1 second per number
            Console.Write("\b \b");
        }
    }
}
