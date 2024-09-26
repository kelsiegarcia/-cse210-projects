// Responsibilities:
// Keeps track of the company, job title, start year, and end year.
// Behaviors:
// Displays the job information 
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