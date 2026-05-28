using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Code Academy", 600);
        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Sarah", "Very helpful."));
        video1.AddComment(new Comment("Mike", "Easy to understand."));

        Video video2 = new Video("Gaming Highlights", "Pro Gamer", 900);
        video2.AddComment(new Comment("Alex", "Awesome gameplay!"));
        video2.AddComment(new Comment("Emma", "Loved this video."));
        video2.AddComment(new Comment("Daniel", "More videos please!"));

        Video video3 = new Video("Cooking Pasta", "Chef Maria", 480);
        video3.AddComment(new Comment("Sophia", "Looks delicious."));
        video3.AddComment(new Comment("James", "Trying this tonight."));
        video3.AddComment(new Comment("Olivia", "Amazing recipe!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}