using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Adobe";
        job1._startYear = 2024;
        job1._endYear = 2025;

        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Logitech";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Bingo Heeler";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayJobDetails();


    }
}