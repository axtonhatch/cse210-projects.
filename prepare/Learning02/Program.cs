using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Elementry school janitor";
        job1._company = "Jordaan School District";
        job1._startYear = 2016;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Lawn mower";
        job2._company = "Hatch Lawn Care";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Axton Hatch";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}