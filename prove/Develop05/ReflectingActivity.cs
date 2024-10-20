using System;

public class ReflectingActivity : Activity
{
	public ReflectingActivity(string name, string description, int duration) : base("Reflecting", "Reflecting is a great way to relax and calm your mind.", duration)
	{

	}

	public void GetRandomPrompt()
	{
		string[] prompts = new string[] { "What are you grateful for today?", "What is something you are looking forward to?", "What is something you are proud of?", "What is something you are struggling with?", "What is something you felt yesterday" };
		Random random = new Random();
		int index = random.Next(prompts.Length);
		Console.WriteLine(prompts[index]);
	}

	private string lastQuestion = "";

	public void GetRandomQuestion()
	{
		string[] questions = new string[] { "How does it make it you feel now?", "Did it make you think of anything in particular?", "Is there something positive from it?", "Is there someone you want to share that with?", "Did you share it with anyone?" };
		Random random = new Random();
		string question;
		do
		{
			int index = random.Next(questions.Length);
			question = questions[index];
		} while (question == lastQuestion);

		lastQuestion = question;
		Console.WriteLine(question);
	}

	public void Run(int duration)
	{
		DisplayStartingMessage();
		Console.WriteLine();
		Console.WriteLine("Reflecting on your day...");
		Console.WriteLine();
		Console.WriteLine("Prompt:");
		Console.WriteLine();
		GetRandomPrompt();
		Console.WriteLine();
		ShowSpinner(5);
		Console.WriteLine("When you have something in mind -- press enter to continue:");
		Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine("Keeping that thought in mind, take a deep breath in... and consider this question:");
		Console.WriteLine();
		GetRandomQuestion();
		Console.WriteLine();
		ShowSpinner(5);
		Console.WriteLine();
		GetRandomQuestion();
		Console.WriteLine();
		ShowSpinner(5);
		Console.WriteLine();
		DisplayEndingMessage();
	}
}