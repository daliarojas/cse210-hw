using System;
using System.Collections.Generic;

namespace youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3-4 videos and set the appropriate values
            List<Media> mediaList = new List<Media>
        {
            new Video("Introduction to Programming", "John Smith", 120),
            new Video("Data Structures and Algorithms", "Alice Johnson", 180),
            new Video("Machine Learning Basics", "Bob Williams", 150)
        };

            // Add comments for each video
            ((Video)mediaList[0]).AddComment("Commenter 1", "Great video!");
            ((Video)mediaList[0]).AddComment("Commenter 2", "Nice work!");

            ((Video)mediaList[1]).AddComment("Commenter 3", "Interesting content.");
            ((Video)mediaList[1]).AddComment("Commenter 1", "Keep it up!");

            ((Video)mediaList[2]).AddComment("Commenter 2", "I learned a lot.");
            ((Video)mediaList[2]).AddComment("Commenter 3", "Thanks for sharing!");

            // Iterate through the list of videos and display information
            foreach (var media in mediaList)
            {
                media.DisplayInformation();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}