using System;
using System.Security.Cryptography.X509Certificates;


//Author: Monsuru Oladipo. CSE 210
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
       
        List<Video> videos = new List<Video>();
        Video video1 = new("Intro to art", "Paul Boyd", 20);
        video1.AddComment(new Comment("Jane", "Superb"));
        video1.AddComment(new Comment("Jack", "Great"));
        video1.AddComment(new Comment("Jerry", "Amazing"));
        videos.Add(video1);
        
        Video video2 = new("History of England", "John Doe", 40);
        video2.AddComment(new Comment("Jane", "Amazing"));
        video2.AddComment(new Comment("Jack", "Great"));
        video2.AddComment(new Comment("Michael", "superb"));
        videos.Add(video2);
       
        Video video3 = new("Great Civilizations", "Paul Jake", 30);
        video3.AddComment(new Comment("Jane", "Superb"));
        video3.AddComment(new Comment("Jane", "Superb"));
        video3.AddComment(new Comment("Jack", "Great"));
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.displayVideoInfo();
            Console.WriteLine($"Number of comments: {video.GetNumberOfComment()}");

        }











    }
}