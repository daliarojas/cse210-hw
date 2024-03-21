using System;

namespace Journal
{
class Program 
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;
        do
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the Journal");
                Console.WriteLine("3. Save the Journal to a File"); 
                Console.WriteLine("4. Load the Journal from a File");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                       Console.WriteLine("What is your name?:");
                       string fullName = Console.ReadLine();
                       Console.WriteLine("Writing a new entry:");
                       string prompt = PromptGenerator.GetRandomPrompt();
                       Console.WriteLine("Prompt: " + prompt);
                       Console.Write("Response: ");
                       string response = Console.ReadLine();
                       journal.AddEntry(new Entry(fullName, DateTime.Now, prompt, response));
                       break;
                    case "2":
                       Console.WriteLine("Displaying the journal:");
                       journal.DisplayEntries();
                       break;
                    case "3":
                       Console.Write("Enter filename to save: ");
                       string saveFilename = Console.ReadLine();
                       journal.SaveToFile(saveFilename);
                       Console.WriteLine("Journal saved to file.");
                       break;
                    case "4":
                       Console.Write("Enter filename to load: ");
                       string loadFilename = Console.ReadLine();
                       journal.LoadFromFile(loadFilename);
                       Console.WriteLine("Journal loaded from file.");
                       break;
                    case "5":
                       Console.WriteLine("Exiting the program.");
                       break;
                    default:
                       Console.WriteLine("Invalid choice. Please try again");
                       break;            


                }
            }while (choice != "5");
        
    }
}
}