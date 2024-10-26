using System;
using System.Collections.Generic;

public abstract class Goal
{
	public string Name { get; }
	public string Description { get; }
	public int Points { get; }

	public Goal(string name, string description, int points)
	{
		Name = name;
		Description = description;
		Points = points;
	}

	public abstract void RecordEvent(string eventDescription);
	public abstract bool IsCompleted();
	public abstract bool CheckIfCompleted();
	public abstract void CompleteGoal();
	public abstract string GetDetailsString();
	public abstract string GetStringRepresentation();
	public abstract List<string> GetEvents();
}