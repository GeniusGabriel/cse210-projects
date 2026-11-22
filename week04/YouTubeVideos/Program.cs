using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Python Tutorial", "Brother Burton", 120);
        video1.AddComment(new Comment("Alice", "Great video!"));
        videos.Add(video1);
        Video video2 = new Video("C# Tutorial", "Sister Smith", 180);
        video2.AddComment(new Comment("Bob", "Very helpful!"));
        videos.Add(video2);
        foreach (Video video in videos)
        {
            
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine(video.GetComments());
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
        }
    }
}