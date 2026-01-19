using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Developer";
        job1._company = "Theach solition";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();

        job2._jobTitle = "Web Designer";
        job2._company = "Creative Studio";
        job2._startYear = 2011;
        job2._endYear = 2025;


        Resume ResumeObject = new Resume();

        ResumeObject._namePerson = "William";

        ResumeObject._jobs.Add(job1);
        ResumeObject._jobs.Add(job2);
        
        ResumeObject.Display();

    }
    
}