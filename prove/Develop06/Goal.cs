public abstract class Goal
{
	protected string _shortName;
	protected string _description;
	protected int _points;

	public Goal(string shortName, string description, int points)
	{
		_shortName = shortName;
		_description = description;
		_points = points;
	}

	public abstract void RecordEvent();

	public abstract bool IsComplete();

	public string GetDetailsString()
	{
		// This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description.Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
		return $"{_shortName}: {_description} ({_points} points)";
	}


	public abstract string GetStringRepresntation();

	// This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.

}