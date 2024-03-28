using System;
using scripture;

namespace Scripture
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
            // Have the program to load scriptures from a files.
            
            string randoScripture = LoadScripture.LoadRandomScripture();
            string apostle = randoScripture.Split(';')[0];
            string text = randoScripture.Split(';')[1];

            ScriptureReference reference = new ScriptureReference(apostle);
            Scripture scripture = new Scripture(reference,text);

            while (true)
            {
                //Console.Clear();
                scripture.Display();
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine().ToLower();
                if (input == "quit")
                    break;
                else
                {
                    if (!scripture.HideRandomWord())
                    {
                        Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}