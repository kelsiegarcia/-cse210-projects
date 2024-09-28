using System.IO;
// Class: Journal
// Responsibilities:
public class Journal
{
	// store the list of entries and defining objects
	public List<Entry> _entries = new List<Entry>();
	// get randomgenerator class create new object
	public PromptGenerator _prompts = new PromptGenerator();
	// AddEntry(newEntry: Entry) : void
	public void AddEntry()
	{
		Entry _entry = new Entry();
		_entry._date = DateTime.Now.ToShortDateString();
		_entry._promptText = _prompts.GetRandomPrompt();
		Console.WriteLine($"Writing prompt: {_entry._promptText}");
		_entry._entryText = Console.ReadLine();

		_entries.Add(_entry);

	}
	//Behaviors:
	//display all the entries calling the entry display method keeps details of the entries in the entry class. Plus I holds all the info anyway, why not display it
	// DisplayAll() : void
	public void DisplayAll()
	{
		foreach (Entry entry in _entries)
		{
			entry.DisplayEntry();
			Console.WriteLine();
		}
	}
	// Saving the new entry into file with all the other compiled entries
	// SaveToFile(file: string) : void
	// how can i check that it saved? and does the user need to write with "" everytime the save and load?
	string filename = "myJournal.txt";
	public void SaveToFile(string filename)
	{
		using (StreamWriter sw = new StreamWriter(filename))
		{
			foreach (Entry entry in _entries)
			{
				sw.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
			}
		}
	}
	// LoadFromFile(file: string) : void
	public void LoadFromFile(string filename)
	{
		_entries.Clear();
		string[] lines = System.IO.File.ReadAllLines(filename);
		// string[] lines = File.ReadAllLines(filename);

		foreach (string line in lines)
		{
			string[] parts = line.Split("|");

			Entry _entry = new Entry();
			_entry._date = parts[0];
			_entry._promptText = parts[1];
			_entry._entryText = parts[2];

			_entries.Add(_entry);
		}
	}
}