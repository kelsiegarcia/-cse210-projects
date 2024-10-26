public class EternalGoal : Goal
{
	private List<string> _events;

	public EternalGoal(string name, string description, int points) : base(name, description, points)
	{
		_events = new List<string>();
	}

	public override void RecordEvent(string eventDescription)
	{
		_events.Add(eventDescription);
		Console.WriteLine($"Event recorded for eternal goal '{Name}': {eventDescription}");
	}

	public override bool CheckIfCompleted()
	{
		Console.WriteLine($"Eternal goal '{Name}' is ongoing and cannot be completed.");
		return false; // Eternal goals are never completed
	}

	public override void CompleteGoal()
	{
		Console.WriteLine($"Eternal goal '{Name}' is ongoing and cannot be completed.");
	}

	public override string GetDetailsString()
	{
		return $"{Name}: {Description} - Points: {Points}";
	}

	public override string GetStringRepresentation()
	{
		return $"{Name}: {Description} - Points: {Points}";
	}

	public override List<string> GetEvents()
	{
		return _events;
	}

	public override bool IsCompleted()
	{
		return false; // Eternal goals are never completed
	}
}
