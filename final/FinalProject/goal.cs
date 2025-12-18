using System.Collections.Generic;

public class Goal
{
    protected string name;
    protected List<TaskItem> tasks;

    public Goal(string name)
    {
        this.name = name;
        tasks = new List<TaskItem>();
    }

    public void AddTask(string description)
    {
        tasks.Add(new TaskItem(description));
    }

    public virtual void DisplayProgress()
    {
        int completed = 0;

        foreach (TaskItem task in tasks)
        {
            if (task.IsComplete)
            {
                completed++;
            }
        }

        Console.WriteLine($"{name}: {completed}/{tasks.Count} tasks completed ");
    }
}
