using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity()
        {
            _prompts = new List<string>();
            _questions = new List<string>();

            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");

            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");
        }

        public override void Run()
        {
            Console.WriteLine("Reflection Activity");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            Console.WriteLine("Enter duration of activity in seconds:");
            int duration = int.Parse(Console.ReadLine());
            //SetDuration(duration);

            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);
            base.ShowSpinner(duration);

            Random rand = new Random();

            for (int i = 0; i < duration; i += 10)
            {
                string randomPrompt = _prompts[rand.Next(0, _prompts.Count)];
                Console.WriteLine(randomPrompt);

                foreach (string question in _questions)
                {
                    Console.WriteLine(question);
                    ShowCountdown(duration);
                }
            }

            Console.WriteLine("Well done! You have completed the Reflection Activity.");
            Thread.Sleep(3000);
        }

        public string GetRandoPrompt()
        {
            return null;
        }

        public string GetRamdomQuestions()
        {
            return null;
        }

        public void DisplayPrompt()
        {

        }

        public void DisplayQuestions()
        {

        }
    }
}