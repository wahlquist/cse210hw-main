using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Running s1 = new Running("03 Nov 2024", 30,3);
        activities.Add(s1);

        Swimming s2 = new Swimming("03 Nov 2024", 15, 5);
        activities.Add(s2);

        Cycling s3 = new Cycling("03 Nov 2024",20, 6);
        activities.Add(s3);

        foreach (var activity in activities)
        {
           
            string date = activity.GetColor();
            double time = activity.GetTime();
           
            double distance = activity.GetDistance();
            double speed = activity.GetSpeed();
            double pace = activity.GetPace();

            Console.WriteLine($"The {date} ({time}min) Distance {distance}km, speed:{speed}kph, Pace:{pace}min/km");
        }
    }
}