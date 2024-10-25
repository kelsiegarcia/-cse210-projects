public class SimpleGoal : Goal
{
	private bool _isComplete;

	public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
	{
		// _isComplete = false;
	}

	public override void RecordEvent()
	{
		// _isComplete = true;
	}

	public override bool IsComplete()
	{
		// return _isComplete;
		return _isComplete;
	}

	public override string GetStringRepresntation()
	{

		return $"{_shortName}: {_description} - Points: {_points}, Complete: {_isComplete}";
	}

}