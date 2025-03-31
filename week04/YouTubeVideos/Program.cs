using System;
using System.Security.Cryptography.X509Certificates;


//Author: Monsuru Oladipo. CSE 210
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new("Intro to art", "mike boyd", 20);
        video1.AddComment(new Comment("Jane", "superb"));
        video1.AddComment(new Comment("Jack", "Great"));
        video1.AddComment(new Comment("Jerry", "Amazing"));
        videos.Add(video1);

        Video video2 = new("History of England", "John Does", 40);
        video2.AddComment(new Comment("Jane", "superb"));
        video2.AddComment(new Comment("Jack", "Great"));
        video2.AddComment(new Comment("Jane", "superb"));
        videos.Add(video2);


        Video video3 = new("Math 101", "Paul Jake", 30);
        video3.AddComment(new Comment("Jane", "superb"));
        video3.AddComment(new Comment("Jane", "superb"));
        video3.AddComment(new Comment("Jack", "Great"));
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.displayVideoInfo();
            Console.WriteLine($" Number of comments: {video.GetNumberOfComment()}");

        }











    }
}