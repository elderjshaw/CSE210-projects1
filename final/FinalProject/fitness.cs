public class FitnessGoal : Goal
{
    public FitnessGoal(string name) : base(name)
    {
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"Fitness Goal Progress: ");
        base.DisplayProgress();
    }
}
