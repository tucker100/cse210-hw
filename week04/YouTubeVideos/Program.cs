using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Unboxing the SolarMax Power Bank", "TechWithTunde", 612);
        video1.AddComment(new Comment("Amaka", "I bought this last month and it charges my phone three times."));
        video1.AddComment(new Comment("Chidi", "Does it work with laptops too?"));
        video1.AddComment(new Comment("Grace", "Great review, very clear."));
        videos.Add(video1);

        Video video2 = new Video("Morning Routine with GreenLeaf Tea", "HealthyHabitsDaily", 845);
        video2.AddComment(new Comment("Samuel", "I switched to this tea and love it."));
        video2.AddComment(new Comment("Blessing", "Where can I buy it?"));
        video2.AddComment(new Comment("Kwame", "Nice video, the lighting is beautiful."));
        video2.AddComment(new Comment("Ruth", "Please do an evening routine next!"));
        videos.Add(video2);

        Video video3 = new Video("Top 5 Running Shoes of the Year", "RunFastReviews", 1023);
        video3.AddComment(new Comment("David", "The StrideOne pair is my favorite."));
        video3.AddComment(new Comment("Esther", "You forgot to mention the price."));
        video3.AddComment(new Comment("Joseph", "Very helpful comparison."));
        videos.Add(video3);

        Video video4 = new Video("Cooking Jollof Rice with QuickChef Pot", "KitchenWithMama", 978);
        video4.AddComment(new Comment("Ngozi", "This pot saves so much time."));
        video4.AddComment(new Comment("Emeka", "My jollof came out perfect following this."));
        video4.AddComment(new Comment("Fatima", "Can you share the full recipe?"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}