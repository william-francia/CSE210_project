using System;
using System.Reflection.Metadata;

class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal (string shortName, string description, int points, bool isComplete = false) : base (shortName, description, points)
    {
        _IsComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
    }
    public override bool IsComplete()
    {
        return _IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}|{_description}|{_points}|{_IsComplete}";
    }
        public override string GetDetailsString()
    {
        string checkbox = _IsComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }
}