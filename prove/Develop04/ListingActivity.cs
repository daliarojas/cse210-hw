using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        int _count;
        private List<string> _prompts;


        public ListingActivity()
        {
            _prompts = new List<string>();

            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week ? ");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }

        public override void Run()
        {
            Console.WriteLine("Listing Activity");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            Console.WriteLine("Enter duration of activity in seconds:");
            int duration = int.Parse(Console.ReadLine());
            //SetDuration(duration);

            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);
            base.ShowSpinner(duration);

            Random rand = new Random();
            string randomPrompt = _prompts[rand.Next(0, _prompts.Count)];
            Console.WriteLine(randomPrompt);

            Console.WriteLine("You have " + duration + " seconds to list as many items as you can.");

            Thread.Sleep(duration * 1000);

            Console.WriteLine("Time's up!");

            // Assuming the user inputs their list during the duration
            Console.WriteLine("How many items did you list?");
            int itemCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"You listed {itemCount} items.");
            Console.WriteLine("Well done! You have completed the Listing Activity.");
            Thread.Sleep(3000);
        }

        public void GetRandomPrompt()
        {

        }

        public List<string> GetListFromUser()
        {
            return null;
        }
    }
}