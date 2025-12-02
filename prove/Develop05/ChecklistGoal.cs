public class ChecklistGoal : Goal
{
    private int TimesCompleted;
    private int Target;
    private int BonusPoints;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)

    {
        Target = target;
        BonusPoints = bonus;
    }

    public override int RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted >= Target)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }

        return Points;
    }

    public override string Display()

    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} — Completed {TimesCompleted}/{Target} times ";
    }
}
