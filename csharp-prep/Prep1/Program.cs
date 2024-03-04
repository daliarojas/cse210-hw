using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter their name
        Console.Write("What is your first name? ");
 
        // Read the input from the user
        string firstname = Console.ReadLine();
 
        // Ask the user to enter their name
        Console.Write("What is your last name? ");
 
        // Read the input from the user
        string lastname = Console.ReadLine();
 
        Console.WriteLine("Your name is " + lastname + ", " + firstname + " " + lastname + "." );
    }
}