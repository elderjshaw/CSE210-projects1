using System;

class Program
{
    static GoalManager manager = new GoalManager();

    static void Main()
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program ");
            Console.WriteLine("1. Create Goal ");
            Console.WriteLine("2. Record Event ");
            Console.WriteLine("3. View Goals and Score ");
            Console.WriteLine("4. Quit");
            Console.Write("Choose: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordGoal(); break;
                case "3": ShowGoals(); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal ");
        Console.Write("Choose type: ");
        string type = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            manager.AddGoal(new SimpleGoal(name, points));
        else if (type == "2")
            manager.AddGoal(new EternalGoal(name, points));
        else if (type == "3")
        {
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());
            manager.AddGoal(new ChecklistGoal(name, points, target, bonus));
        }
    }

    static void RecordGoal()
    {
        Console.WriteLine("Choose goal to record: ");
        manager.DisplayGoals();
        int choice = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(choice);
    }

    static void ShowGoals()
    {
        manager.DisplayGoals();
        manager.DisplayScore();
        Console.ReadKey();
    }
}
