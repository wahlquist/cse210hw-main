using System;

class Program
{ public static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        
        Video video1 = new Video("I eat a human!! irl not clickbait!!","yourdailycannabal56",200);
   
       
        Comment comment1 = new Comment("jared","whose still here in 2023");
  
        Comment comment2 = new Comment("Dave","i wonder where he got them");

 
        Comment comment3 = new Comment("taylieh","Where can i get some");
   


        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

      

        Video video2 = new Video("how the french tie there shoes" ,"disabilityawarness",400);
  
Comment comment4 = new Comment("darel","where can i get one for my house");

        Comment comment5 = new Comment("sharlene","whats with the hate against france");
  
        Comment comment6 = new Comment("jean","quelque chose en français");



        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);



        Video video3 = new Video("The govenment knows eveything about you","bourgeoisieBirds",600);

        Comment comment7 = new Comment("hoot","first comment");

        Comment comment8 = new Comment("vancouver","The birds work for the bousuise");

        Comment comment9 = new Comment("kyle","Watch this video get taken down imedietly");



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