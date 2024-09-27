//Responsibilties:
// should keep track of the date, promp text, and text of entry
// Display the entry information
public class Entry
{
	// set all the Entry details with variables
	// _date: string
	public string _date;
	// _promptText : string
	public string _promptText;
	// _entryText : string
	public string _entryText;


	// Behavior
	// Display() : void
	public void DisplayEntry()
	{
		Console.WriteLine($"Entry Date: {_date}");
		Console.WriteLine($"Prompt Given: {_promptText}");
		Console.WriteLine($"Your Entry: {_entryText}");

	}
}