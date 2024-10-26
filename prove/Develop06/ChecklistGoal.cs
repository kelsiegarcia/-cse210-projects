namespace YourNamespace
{
	public class ChecklistGoal : Goal
	{
		private List<string> _events;
		private int _amountCompleted;
		private int _target;
		private int _bonus;

		public ChecklistGoal(string name, string description, int points, int target, int bonus)
				: base(name, description, points)
		{
			_events = new List<string>();
			_amountCompleted = 0;
			_target = target;
			_bonus = bonus;
		}

		public override void RecordEvent(string eventDescription)
		{
			_events.Add(eventDescription);
			_amountCompleted++;
			Console.WriteLine($"Event recorded for checklist goal '{Name}': {eventDescription}. Progress: {_amountCompleted}/{_target}");
			if (_amountCompleted >= _target)
			{
				CompleteGoal();
			}
		}

		public override bool CheckIfCompleted()
		{
			return _amountCompleted >= _target;
		}

		public override void CompleteGoal()
		{
			Console.WriteLine($"Checklist goal '{Name}' completed! Bonus: {_bonus} points.");
		}

		public override string GetDetailsString()
		{
			return $"{Name}: {Description} - Points: {Points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
		}

		public override string GetStringRepresentation()
		{
			return $"{Name}: {Description} - Points: {Points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
		}

		public override bool IsCompleted()
		{
			return _amountCompleted >= _target;
		}

		public override List<string> GetEvents()
		{
			return _events;
		}
	}
}

