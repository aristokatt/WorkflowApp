// See https://aka.ms/new-console-template for more information
//Takes in a list of activities and creates a workflow
public class Workflow
{
    private readonly List<IActivity> _workflow;
    public Workflow(List<IActivity> activities)
    {
        _workflow = activities;
    }
    public IEnumerable<IActivity> GetActivities()
    {
        return _workflow;
    }

    public void Add(IActivity activity)
    {
        _workflow.Add(activity);
    }

    public void Remove(IActivity activity)
    {
        _workflow.Remove(activity);
    }
}
