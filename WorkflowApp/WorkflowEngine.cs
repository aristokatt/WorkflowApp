// See https://aka.ms/new-console-template for more information
//Takes in a workflow and executes each activity in the workflow
public class WorkflowEngine
{
    private readonly Workflow _workflow;
    public WorkflowEngine(Workflow workflow)
    {
        _workflow = workflow;
    }
    public void Run()
    {
        foreach (var activity in _workflow.GetActivities())
        {
            activity.Execute();
        }
    }
}
