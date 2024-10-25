public class GoalManager
{
	// list of goals 
	private List<Goal> goals = new List<Goal>();
	// score of the player
	private int score;

	// constructor
	public GoalManager()
	{
		// initialize empty list of goals
		// set the score to 0
	}
	// start the game
	public void Start()
	{

		// display the current balance of points which should be 0
		// DisplayPlayerInfo();
		// Display a menu of options for the player to choose from
		Console.WriteLine("Menu options:");
		Console.WriteLine("1. Create new goal");
		Console.WriteLine("2. List Goals");
		Console.WriteLine("3. Save Goals");
		Console.WriteLine("4. Load Goals");
		Console.WriteLine("5. Record an event");
		Console.WriteLine("6. Quit");
		Console.Write("Select a choice from the menu");
		int option = int.Parse(Console.ReadLine());

		switch (option)
		{
			case 1:
				CreateGoal();
				break;
			case 2:
				ListGoalNames();
				ListGoalDetails();

				break;
			case 3:
				SaveGoals();
				break;
			case 4:
				LoadGoals();
				break;
			case 5:
				RecordEvent();
				break;
			case 6:
				Console.WriteLine("Goodbye!");
				break;
			default:
				Console.WriteLine("Invalid option. Please try again.");
				break;
		}


	}
	public void DisplayPlayerInfo()
	{
		// print the score of the player
		Console.WriteLine("Score: " + score);
	}

	public void ListGoalNames()
	{
		// Implementation here
	}

	public void ListGoalDetails()
	{
		// Implementation here
	}

	public void CreateGoal()
	{
		// Implementation here
	}

	public void RecordEvent()
	{
		// Implementation here
	}

	public void SaveGoals()
	{
		// Implementation here
	}

	public void LoadGoals()
	{
		// Implementation here
	}



}