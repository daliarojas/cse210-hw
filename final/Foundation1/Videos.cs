using System;
using System.Collections.Generic;


namespace youtube
{
    public class Video: Media
    {
        public List<Comment> Comments { get; }

        public Video(string title, string author, int length) : base(title, author, length)
        {
            Comments = new List<Comment>();
        }

        public void AddComment(string name, string text)
        {
            Comments.Add(new Comment(name, text));
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of Comments: {Comments.Count}");

            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
        }
    }
}