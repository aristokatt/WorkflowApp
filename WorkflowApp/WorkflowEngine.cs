﻿// See https://aka.ms/new-console-template for more information
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
