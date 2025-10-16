using System;

class Program
{
    static List<string> journalEntries = new List<string>();
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    Console.WriteLine();
                    break;

                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
        
    }

}