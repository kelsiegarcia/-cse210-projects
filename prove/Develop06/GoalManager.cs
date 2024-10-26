using System;
using System.Collections.Generic;

namespace GoalManagerApp
{
	public class GoalManager
	{
		private List<Goal> goals;

		public GoalManager()
		{
			goals = new List<Goal>();
		}

		public void AddGoal(Goal goal)
		{
			goals.Add(goal);
		}

		public void RemoveGoal(Goal goal)
		{
			goals.Remove(goal);
		}

		public List<Goal> GetGoals()
		{
			return new List<Goal>(goals);
		}

		public void DisplayGoals()
		{
			foreach (var goal in goals)
			{
				Console.WriteLine(goal.ToString());
			}
		}
	}

	public class Goal
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Deadline { get; set; }
		private List<string> events;

		public Goal()
		{
			events = new List<string>();
		}

		public void RecordEvent(string eventDescription)
		{
			events.Add(eventDescription);
		}

		public List<string> GetEvents()
		{
			return new List<string>(events);
		}

		public override string ToString()
		{
			return $"{Name}: {Description} (Deadline: {Deadline.ToShortDateString()})";
		}
	}
}