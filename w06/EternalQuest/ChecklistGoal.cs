using System;

public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public override int RecordEvent()
  {
    if (!IsComplete())
    {
      _amountCompleted++;
      if (_amountCompleted == _target)
      {
        return GetPoints() + _bonus;
      }
      return GetPoints();
    }
    return 0;
  }

  public override bool IsComplete()
  {
    return _amountCompleted >= _target;
  }

  public override string GetDetailsString()
  {
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
  }
}
