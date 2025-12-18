public class TaskItem
{
    public string Description { get; private set; }
    public bool IsComplete { get; private set; }

    public TaskItem(string description)
    {
        Description = description;
        IsComplete = false;
    }

    public void Complete()
    {
        IsComplete = true;
    }
}
