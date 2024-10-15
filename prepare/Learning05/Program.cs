using System;

class Program
{
	static void Main(string[] args)
	{
		Assignment assignment = new Assignment("John Doe", "Mathematics");
		Console.WriteLine(assignment.GetSummary());

		MathAssignment mathAssignment = new MathAssignment("Jane Doe", "Statistics", "Chapter 3", "Problem 5");
		Console.WriteLine(mathAssignment.GetSummary());
		Console.WriteLine(mathAssignment.GetHomeworkList());

		WritingAssignment writingAssignment = new WritingAssignment("John Smith", "History", "The American Revolution");
		Console.WriteLine(writingAssignment.GetSummary());
		Console.WriteLine(writingAssignment.GetWritingInformation());
	}
}