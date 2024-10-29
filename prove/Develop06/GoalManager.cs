using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
	private List<Goal> _goals;
	private int _score;

	public GoalManager(int _points)
	{
		_goals = new List<Goal>();
		_score = 0;
	}

	public void Start()
	{
		Console.WriteLine("Welcome to the Goal Manager!");
	}

	public void AddGoal(Goal goal)
	{
		_goals.Add(goal);
	}

	public void RecordEvent(int index)
	{
		if (index >= 0 && index < _goals.Count)
		{
			int initialPoints = _goals[index]._points;
			_goals[index].RecordEvent();
			int pointsEarned = _goals[index]._points - initialPoints;
			_score += pointsEarned;
			Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
		}
	}

	public void DisplayGoals()
	{
		if (_goals.Count == 0)
		{
			Console.WriteLine("No goals have been created yet.");
			return;
		}

		Console.WriteLine("The goals are:");
		for (int i = 0; i < _goals.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
		}
	}

	public void DisplayScore()
	{
		Console.WriteLine($"You have {_score} points.");
	}

	public void SaveGoals(string filename)
	{
		using (StreamWriter writer = new StreamWriter(filename))
		{
			writer.WriteLine(_score);
			foreach (Goal goal in _goals)
			{
				writer.WriteLine(goal.GetStringRepresentation());
			}
		}
	}

	public void LoadGoals(string filename)
	{
		// _goals.Clear();
		try
		{
			string[] lines = File.ReadAllLines(filename);

			if (lines.Length == 0)
			{
				Console.WriteLine("The file is empty.");
				return;
			}

			_score = int.Parse(lines[0]);

			for (int i = 1; i < lines.Length; i++)
			{
				string[] parts = lines[i].Split(":");
				if (parts.Length != 2)
				{
					Console.WriteLine($"Invalid line format at line {i + 1}: {lines[i]}");
					continue;
				}

				string goalType = parts[0];
				string[] data = parts[1].Split(",");

				switch (goalType)
				{
					case "SimpleGoal":
						if (data.Length != 4)
						{
							Console.WriteLine($"Invalid SimpleGoal format at line {i + 1}: {lines[i]}");
							continue;
						}
						SimpleGoal simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
						if (bool.Parse(data[3])) simpleGoal.RecordEvent();
						_goals.Add(simpleGoal);
						break;

					case "EternalGoal":
						if (data.Length != 3)
						{
							Console.WriteLine($"Invalid EternalGoal format at line {i + 1}: {lines[i]}");
							continue;
						}
						_goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
						break;

					case "ChecklistGoal":
						if (data.Length != 6)
						{
							Console.WriteLine($"Invalid ChecklistGoal format at line {i + 1}: {lines[i]}");
							continue;
						}
						ChecklistGoal checklistGoal = new ChecklistGoal(
							data[0], data[1], int.Parse(data[2]),
							int.Parse(data[3]), int.Parse(data[4]));

						int completedTimes = int.Parse(data[5]);
						for (int j = 0; j < completedTimes; j++)
						{
							checklistGoal.RecordEvent();
						}
						_goals.Add(checklistGoal);
						break;

					default:
						Console.WriteLine($"Unknown goal type at line {i + 1}: {goalType}");
						break;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
		}
	}
}