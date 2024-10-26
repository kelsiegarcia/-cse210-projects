using System;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		List<Goal> goals = new List<Goal>();

		Console.WriteLine("Welcome to the Goal Quest Game!");
		while (true)
		{
			Console.WriteLine("\n1. Add New Goal");
			Console.WriteLine("\n2. List Goals");
			Console.WriteLine("\n3. Save Goals");
			Console.WriteLine("\n4. Record Goal");
			Console.WriteLine("\n5. Show Goals");
			Console.WriteLine("\n6. Exit");
			Console.Write("Choose an option: ");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					Console.WriteLine("1. Simple Goal");
					Console.WriteLine("2. Eternal Goal");
					Console.Write("Choose a goal type: ");
					string goalType = Console.ReadLine();
					switch (goalType)
					{
						case "1":
							Console.Write("Enter goal name: ");
							string simpleName = Console.ReadLine();
							Console.Write("Enter goal description: ");
							string simpleDescription = Console.ReadLine();
							Console.Write("Enter points: ");
							int simplePoints = int.Parse(Console.ReadLine());
							goals.Add(new SimpleGoal(simpleName, simpleDescription, simplePoints));
							break;
						case "2":
							Console.Write("Enter goal name: ");
							string eternalName = Console.ReadLine();
							Console.Write("Enter goal description: ");
							string eternalDescription = Console.ReadLine();
							Console.Write("Enter points: ");
							int eternalPoints = int.Parse(Console.ReadLine());
							goals.Add(new EternalGoal(eternalName, eternalDescription, eternalPoints));
							break;
						case "3":
							Console.WriteLine("Invalid option. Please try again.");
							break;
					}
					break;
				case "2":
					//list the goals
					Console.WriteLine("Goals:");
					foreach (var g in goals)
					{
						Console.WriteLine($"- {g.Name}: {g.Description} (Completed: {g.IsCompleted})");
					}
					break;
				case "3":
					//save the goals
					Console.Write("Enter file name: ");
					string fileName = Console.ReadLine();
					using (StreamWriter writer = new StreamWriter(fileName))
					{
						foreach (var g in goals)
						{
							writer.WriteLine($"{g.Name},{g.Description},{g.IsCompleted}");
						}
					}
					break;
				case "4":
					//record a goal
					Console.Write("Enter goal name to record: ");
					string goalName = Console.ReadLine();
					Goal goal = goals.Find(g => g.Name == goalName);
					if (goal != null)
					{
						Console.Write("Enter event description: ");
						string eventDescription = Console.ReadLine();
						goal.RecordEvent(eventDescription);
					}
					else
					{
						Console.WriteLine("Goal not found.");
					}
					break;
				case "5":
					//show the goals
					Console.Write("Enter goal name: ");
					string goalNameToShow = Console.ReadLine();
					Goal goalToShow = goals.Find(g => g.Name == goalNameToShow);
					if (goalToShow != null)
					{
						Console.WriteLine($"Goal: {goalToShow.Name}");
						Console.WriteLine($"Description: {goalToShow.Description}");
						Console.WriteLine($"Completed: {goalToShow.CheckIfCompleted()}");
						Console.WriteLine("Events:");
						foreach (var e in goalToShow.GetEvents())
						{
							Console.WriteLine($"- {e}");
						}
					}
					else
					{
						Console.WriteLine("Goal not found.");
					}
					break;
				case "6":
					//exit the program
					Console.WriteLine("Goodbye!");
					break;
				default:
					Console.WriteLine("Invalid option. Please try again.");
					break;

			}
		}
	}
}