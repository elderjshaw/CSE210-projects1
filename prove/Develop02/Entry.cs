using System;
using System.Collections.Generic;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} ");
        Console.WriteLine($"Prompt: {_prompt} ");
        Console.WriteLine($"Response: {_response} ");
    }
}