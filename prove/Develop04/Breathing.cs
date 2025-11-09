using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
        "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();  // from base class

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4); 
            Console.Write("\nBreathe out... ");
            ShowCountdown(6); 
            Console.WriteLine();
        }

        EndMessage(); // from base class
    }
}
