using System;

class Program
{ public static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        
        Video video1 = new Video();
        video1._title = "I eat a human!! irl not clickbait!!";
        video1._author = "yourdailycannabal56";
        video1._length = 200;
       
        Comment comment1 = new Comment();
        comment1._name = "jared";
        comment1._comment= "whose still here in 2023";
        Comment comment2 = new Comment();
        comment2._name = "Dave";
        comment2._comment= "i wonder where he got them";
        Comment comment3 = new Comment();
        comment3._name = "taylieh";
        comment3._comment= "Where can i get some";


        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

      

        Video video2 = new Video();
        video2._title = "how the french tie there shoes";
        video2._author = "disabilityawarness";
        video2._length = 400;

Comment comment4 = new Comment();
        comment4._name = "darel";
        comment4._comment= "where can i get one for my house";
        Comment comment5 = new Comment();
        comment5._name = "sharlene";
        comment5._comment= "whats with the hate against france";
        Comment comment6 = new Comment();
        comment6._name = "jean";
        comment6._comment= "quelque chose en français";


        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);



        Video video3 = new Video();
        video3._title = "The govenment knows eveything about you";
        video3._author = "bourgeoisieBirds";
        video3._length = 600;
        Comment comment7 = new Comment();
        comment7._name = "hoot";
        comment7._comment= "first comment";
        Comment comment8 = new Comment();
        comment8._name = "vancouver";
        comment8._comment= "The birds work for the bousuise";
        Comment comment9 = new Comment();
        comment9._name = "kyle";
        comment9._comment= "Watch this video get taken down imedietly";


        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);



    


        



    foreach (var video in videos)
{
video.Display();
}







        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        // Job job2 = new Job();
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job2._startYear = 2022;
        // job2._endYear = 2023;

        // Resume myResume = new Resume();
        // myResume._name = "Allison Rose";

        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // myResume.Display();
    }
}