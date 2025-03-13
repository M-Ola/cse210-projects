using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new();
        Job job2 = new();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2015;
        job1._endYear = 2020;

        job2._jobTitle = "Manager";
        job2._company = "Google";
        job2._startYear = 2020;
        job2._endYear = 2023;




        /* Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job1._company);
        
         Console.WriteLine(job2._jobTitle);
 */
       // job1.DisplayJobDetail();
       // job2.DisplayJobDetail();

        Resume myResume = new()
        {
            _fullName = "Monsuru Oladipo"
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //string b=  myResume._jobs[0]._jobTitle;

        myResume.DisplayResume();


    }






}