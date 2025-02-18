using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(30, 3.5f));
        activities.Add(new Cycling(30, 7.2f));
        activities.Add(new Swimming(30, 8));
        foreach (Activity a in activities){
            Console.WriteLine(a.GetSummary());
        }
    }
}