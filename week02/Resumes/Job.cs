using System;

public class Job
{
    // Member variables (responsibilities)
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Behavior: display the job as "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}