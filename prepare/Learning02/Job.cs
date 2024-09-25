// Class: Resume
// Responsibilities:
// Keeps track of the person's name and a list of their jobs.
// Behaviors:
// Displays the resume, which shows the name first, followed by displaying each one of the jobs.
// Based on these descriptions, you could create class diagrams like the following:
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }
    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {_jobTitle}, Company Title: ({_company}), Start date & End date: {_startYear}-{_endYear}");
    }

}