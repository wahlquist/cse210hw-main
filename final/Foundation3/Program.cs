using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a base "Assignment" object
         Console.Clear();
         Event a1 = new Event("Title goes here", "A short description","Date here", "Time of event","address");
         Console.WriteLine(a1.GetSummary());
        Console.WriteLine("");

        // Now create the derived class assignments
        Lectures a2 = new Lectures("Lectures", "listen to a forrum about AI in the workforce", "12/14/24", "11:30am","stc", "Dr. Bob","Has a phd in looking at a computer for overly too long");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.Gettalk());
        Console.WriteLine("");

        Gatherings a3 = new Gatherings("Outside Gatherings", "Hold an event in nature", "12/17/24","9:00am","241 ricks","we are not responsible if it rains on your parade and will not happen if such rain happens");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.Getstatement());
        Console.WriteLine("");

    // Now create the derived class assignments
        Reception a4 = new Reception("Reception for Kathryn & Rob Wittman", "Come celebrate with the Wittmans on this joyus day", "12/19/24", "4:00pm","8077 galent green", "KittenLegMeat@gmail.com");
        Console.WriteLine(a4.GetSummary());
        Console.WriteLine(a4.GetMarried());
    }
}
