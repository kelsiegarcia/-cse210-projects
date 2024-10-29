using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		int runningPoints = 0;
		GoalManager manager = new GoalManager(runningPoints);
		bool running = true;

		while (running)
		{
			manager.DisplayScore();
			Console.WriteLine("\nMenu Options: ");

			Console.WriteLine("1. Create New Goal");
			Console.WriteLine("2. List Goals");
			Console.WriteLine("3. Save Goals");
			Console.WriteLine("4. Load Goals");
			Console.WriteLine("5. Record Event");
			Console.WriteLine("6. Display Score");
			Console.WriteLine("7. Quit");
			Console.Write("Select a choice from the menu: ");

			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					CreateGoal(manager);
					break;
				case "2":
					manager.DisplayGoals();
					break;
				case "3":
					Console.Write("Enter filename to save: ");
					manager.SaveGoals(Console.ReadLine());
					break;
				case "4":
					Console.Write("Enter filename to load: ");
					string filename = Console.ReadLine();
					manager.LoadGoals(filename);
					break;
				case "5":
					RecordEvent(manager);
					break;
				case "6":
					manager.DisplayScore();
					break;
				case "7":
					running = false;
					break;
				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}
	}

	static void CreateGoal(GoalManager manager)
	{
		Console.WriteLine("\nThe types of Goals are: ");

		Console.WriteLine("1. Simple Goal");
		Console.WriteLine("2. Eternal Goal");
		Console.WriteLine("3. Checklist Goal");
		Console.Write("Which type of goal would you like to create? ");

		string choice = Console.ReadLine();

		Console.Write("What is the name of your goal? ");
		string name = Console.ReadLine();

		Console.Write("What is a short description of it? ");
		string description = Console.ReadLine();

		Console.Write("What is the amount of points associated with this goal? ");
		int points = int.Parse(Console.ReadLine());

		switch (choice)
		{
			case "1":
				manager.AddGoal(new SimpleGoal(name, description, points));
				break;
			case "2":
				manager.AddGoal(new EternalGoal(name, description, points));
				break;
			case "3":
				Console.Write("How many times does this goal need to be accomplished for a bonus? ");
				int target = int.Parse(Console.ReadLine());

				Console.Write("What is the bonus for accomplishing it that many times? ");
				int bonus = int.Parse(Console.ReadLine());

				manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
				break;
		}
	}

	static void RecordEvent(GoalManager manager)
	{
		Console.WriteLine("\nThe goals are: ");

		manager.DisplayGoals();

		Console.Write("\nWhich goal did you accomplish ? ");

		int goalIndex = int.Parse(Console.ReadLine()) - 1;

		manager.RecordEvent(goalIndex);
	}
}