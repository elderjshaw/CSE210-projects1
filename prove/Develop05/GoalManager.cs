using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    public int Score {get; private set; }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        Score += goals[index].RecordEvent();
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Display()} ");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {Score} ");
    }
}
