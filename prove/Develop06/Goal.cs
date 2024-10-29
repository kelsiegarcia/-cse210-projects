using System;
using System.Collections.Generic;

public abstract class Goal
{
	protected string _shortName;
	protected string _description;
	public int _points;
	protected bool _isComplete;

	public Goal(string name, string description, int points)
	{
		_shortName = name;
		_description = description;
		_points = points;
		_isComplete = false;
	}

	public abstract void RecordEvent();
	public abstract string GetStringRepresentation();
	public abstract bool IsComplete();

	public abstract string GetDetailsString();

}