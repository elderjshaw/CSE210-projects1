using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mathew", 7, 7, 8);
        string text =
        "Ask and it shall be given to you; seek and you shall find; " +
        "knock and the door shall be opened to you.\n " +
        "For every one that asketh receiveth; and he that seeketh findeth; " +
        "and to him that knocketh it shall be opened.";
        Scripture scripture = new Scripture(reference, text);


        // Main loop to hide words and display scripture
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
                break;

            scripture.HideRandWord(3);
        }

        Console.WriteLine("All words are hidden or user Quit, GOODBYE! ");
        
    }

}