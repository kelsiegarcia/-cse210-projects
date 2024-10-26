using System;
using System.Collections.Generic;

// namespace YourNamespace
// {
public class SimpleGoal : Goal
{
	private List<string> _events;

	public SimpleGoal(string name, string description, int points) : base(name, description, points)
	{
		_events = new List<string>();
	}

	public override void RecordEvent(string eventDescription)
	{
		_events.Add(eventDescription);
		Console.WriteLine($"Event recorded for simple goal '{Name}': {eventDescription}");
	}

	public override bool IsCompleted()
	{
		return _events.Count > 0; // Example logic for completion
	}

	public override void CompleteGoal()
	{
		Console.WriteLine($"Goal '{Name}' completed!");
	}

	public override string GetDetailsString()
	{
		return $"{Name}: {Description} - Points: {Points}, Completed: {IsCompleted()}";
	}

	public override string GetStringRepresentation()
	{
		return $"{Name}: {Description} - Points: {Points}, Completed: {IsCompleted()}";
	}

	public override List<string> GetEvents()
	{
		return _events;
	}

	public override bool CheckIfCompleted()
	{
		return _events.Count > 0; // Example logic for completion
	}
}
// }
