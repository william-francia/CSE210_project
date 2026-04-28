using System;
using System.Reflection;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string shortName, string description, int points, int targetCount, int bonusPoints) : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {

            }
        }
    }
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"[ ] {_shortName} ({_description}) -- Currently; {_currentCount}/{_targetCount}";
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
    }

}