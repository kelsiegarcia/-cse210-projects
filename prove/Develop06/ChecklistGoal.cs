
public class ChecklistGoal : Goal
{
	private int _amountCompleted;
	private int _target;
	private int _bonus;

	public ChecklistGoal(string name, string description, int points, int target, int bonus)
			: base(name, description, points)
	{
		_amountCompleted = 0;
		_target = target;
		_bonus = bonus;
	}

	public override void RecordEvent()
	{
		_amountCompleted++;
		_points += 2; // Example increment, adjust as needed
		if (_amountCompleted >= _target)
		{
			_points += _bonus;
			_isComplete = true;
		}
	}

	public override string GetStringRepresentation()
	{
		return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
	}

	public override bool IsComplete()
	{
		return _isComplete;
	}

	public override string GetDetailsString()
	{
		return $"{_shortName}: {_description} - Points: {_points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
	}
}

