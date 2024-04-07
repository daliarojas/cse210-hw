using System;
using System.Threading;

namespace Mindfulness
{
    abstract class Activity
    {
        protected string _name;
        protected string description;
        protected int _duration;

        public Activity()
        {
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine("Welcome to the Activity");
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("Activity is completed");
        }

       public void ShowSpinner(int duration)
        {
            Console.Write("\b \b"); // Erase the - character
            Console.Write("C"); // Initial Pac-Man

            for (int i = 0; i < duration + 20; i += 2)
            {
                Console.Write("\b \b"); // Erase the character

                // Cycle through Pac-Man mouth positions
                switch (i % 4)
                {
                    case 0:
                        Console.Write("<Dalia>");
                        break;
                    case 2:
                        Console.Write("<<");
                        break;
                    case 4:
                        Console.Write(">>");
                        break;
                    case 8:
                        Console.Write("Dalia");
                        break;
                }

                Thread.Sleep(500);
            }

            Console.Write("\b \b"); // Erase the last character
        }


        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}