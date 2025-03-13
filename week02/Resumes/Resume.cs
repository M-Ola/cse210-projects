public class Resume

{


    public string _fullName;

    public List<Job> _jobs = [];



    public void DisplayResume()
    {


        Console.WriteLine($"{_fullName}");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetail();
        }
}
}