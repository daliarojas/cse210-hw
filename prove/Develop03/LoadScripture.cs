using System;
using System.IO;

namespace scripture
{
    public class LoadScripture
    {
        public static string LoadRandomScripture()
        {
            // Specify the file path
            string filePath = "scriptures.txt";

            // Open the file and create a StreamReader to read from it
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Count the number of lines in the file
                int lineCount = File.ReadAllLines(filePath).Length;

                // Generate a random number within the range of lines
                Random rand = new Random();
                int randomLineNumber = rand.Next(0, lineCount);

                // Read the file until reaching the randomly chosen line
                for (int i = 0; i < randomLineNumber; i++)
                {
                    reader.ReadLine();
                }

                // Read and display the randomly chosen line
                return reader.ReadLine();
            }
        }
    }
}