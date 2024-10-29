using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
	public SimpleGoal(string name, string description, int points)
			: base(name, description, points)
	{
	}

	public override void RecordEvent()
	{
		_points += 5;
	}

	public override string GetStringRepresentation()
	{
		return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
	}

	public override bool IsComplete()
	{
		return _isComplete;
	}

	public override string GetDetailsString()
	{
		return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
	}
}
