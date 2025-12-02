using System;

public abstract class Goal
{
    protected string Name;
    protected int Points;
    protected bool IsComplete;

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent(); //Returns points earned

    public virtual string Display()
    {
        return $"[ {(IsComplete ? "X" : " " )} ] {Name} ";
    }

    public bool GetIsComplete()
    {
        return IsComplete; //Returns whether the goal is complete
    }
}
