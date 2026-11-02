using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables (responsibilities)
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Behavior: display the name, then each job
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}