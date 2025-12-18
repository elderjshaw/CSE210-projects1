using System;

public class Menu
{
    private GoalTracker tracker;

    public Menu()
    {
        tracker = new GoalTracker();
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("--- Goal Tracker Menu --- ");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Add Task to Goal ");
            Console.WriteLine("3. View Goals ");
            Console.WriteLine("4. Exit ");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    tracker.AddGoal();
                    break;
                case "2":
                    tracker.AddTaskToGoal();
                    break;
                case "3":
                    tracker.DisplayGoals();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
