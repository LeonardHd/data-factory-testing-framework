// Copyright (c) Microsoft Corporation.

namespace AzureDataFactory.TestingFramework.Models.Pipelines;

public class ActivityNotFoundException : Exception
{
    public ActivityNotFoundException(string activityName) : base($"Activity with name {activityName} was not found in the pipeline")
    {
    }
}