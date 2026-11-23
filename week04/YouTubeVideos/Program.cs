using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Come, Thou Fount of Every Blessing (2011)", "The Tabernacle Choir at Temple Square", 373); // 6:13
        video1.AddComment(new Comment("Hannah Sato", "The arrangement and organ accompaniment give me chills every time."));
        video1.AddComment(new Comment("David Morales", "I listen to this whenever I need calm during a busy week."));
        video1.AddComment(new Comment("Rachel Lindqvist", "Pure vocal blend from start to finish."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Down to the River to Pray", "The Tabernacle Choir at Temple Square", 234); // 3:54
        video2.AddComment(new Comment("Caleb Brooks", "Such a fresh and uplifting take on a classic piece."));
        video2.AddComment(new Comment("Mei-Ling Zhou", "The dynamics in the final verse are extraordinary."));
        video2.AddComment(new Comment("Noah Peterson", "Instant favorite on my Sunday morning playlist."));
        video2.AddComment(new Comment("Tessa Alvarez", "So peaceful and inspiring to start the day."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("For the Beauty of the Earth", "The Tabernacle Choir at Temple Square", 187); // 3:07
        video3.AddComment(new Comment("Samuel Grant", "A timeless reminder to appreciate the simple things around us."));
        video3.AddComment(new Comment("Claire Bennett", "The orchestra and choir together sound incredible."));
        video3.AddComment(new Comment("Owen Takahashi", "Short, serene, and deeply moving."));
        videos.Add(video3);

        // Iterate through the list and display each video and its comments
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}