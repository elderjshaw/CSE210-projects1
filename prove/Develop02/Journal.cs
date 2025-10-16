using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    

    public void AddEntry()
    {
        Entry userEntry = new Entry();
        userEntry.generateDate();
        userEntry.GeneratePrompt();
        userEntry.getResponse();
        _entries.Add(userEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }

            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date: {entry._date}");
                    outputFile.WriteLine($"Prompt: {entry._prompt}");
                    outputFile.WriteLine($"Response: {entry._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
    
    public void LoadFromFile(string filename)   //AI helped with this method
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._response = parts[2];
                    _entries.Add(entry);
                }
            }
        }

        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
}