using System;
using System.Threading;

//As a strech goal added waiting animation spinner to start and end messages

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Mindfulness Program! ");
            Console.WriteLine();
            Console.WriteLine("Menu Options, please select from the following: ");
            Console.WriteLine("1. Start Breathing Activity ");
            Console.WriteLine("2. Start Reflection Activity ");
            Console.WriteLine("3. Start Listing Activity ");
            Console.WriteLine("4. Quit ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye! ");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again. ");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
