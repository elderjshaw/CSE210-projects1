using System;
using System.Collections.Generic;

public class GoalTracker
{
    private List<Goal> goals;

    public GoalTracker()
    {
        goals = new List<Goal>();
    }

    public void AddGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Type (1 = Fitness, 2 = School): ");
        string type = Console.ReadLine();

        if (type == "1")
        {
            goals.Add(new FitnessGoal(name));
        }
        else if (type == "2")
        {
            goals.Add(new SchoolGoal(name));
        }
    }

    public void AddTaskToGoal()
    {
        DisplayGoals();

        Console.Write("Choose goal number: ");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Enter task description: ");
        string desc = Console.ReadLine();

        goals[index].AddTask(desc);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i}. ");
            goals[i].DisplayProgress();
        }
    }
}
