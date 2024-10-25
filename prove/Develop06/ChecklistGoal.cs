// public class ChecklistGoal : Goal
// {
// 	private int _amountCompleted;
// 	private int _target;
// 	private int _bonus;

// 	public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
// 	{
// 		_target = target;
// 		_bonus = bonus;
// 		_amountCompleted = 0;
// 	}

// 	public override void RecordEvent()
// 	{
// 		_amountCompleted++;
// 	}

// 	public override bool IsComplete()
// 	{
// 		return _amountCompleted >= _target;
// 	}

// 	public override string GetStringRepresntation()
// 	{
// 		return base.GetStringRepresntation() + " " + _amountCompleted + "/" + _target;
// 	}

// 	public override string GetDetailsString()
// 	{
// 		return base.GetDetailsString() + " " + _bonus + " bonus points";
// 	}

// }