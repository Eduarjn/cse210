using System;

public class NegativeGoal : Goal
{
public NegativeGoal(string name, string description, int points) : base(name, description, points)
{
}

public override int RecordEvent()
{
// Subtracts points instead of adding
return -_points;
}

public override bool IsComplete()
{
return false; // Bad habits are ongoing tracking
}

public override string GetStringRepresentation()
{
return $"NegativeGoal:{_shortName},{_description},{_points}";
}
}
