public class SchoolGoal : Goal
{
    public SchoolGoal(string name) : base(name)
    {
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"School Goal Progress: ");
        base.DisplayProgress();
    }
}
